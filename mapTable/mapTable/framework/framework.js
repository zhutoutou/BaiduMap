var http = require('http')
var URL = require('url')
var fw = {
    httpGet: function(url, cb) {
        url = encodeURI(url)
        // console.log(url)
        http.get(url, (res) => {
            const { statusCode } = res;
            const contentType = res.headers['content-type'];

            let error;
            if (statusCode !== 200) {
                error = new Error('请求失败。\n' +
                    `状态码: ${statusCode}`);
            }
            // else if (!/^application\/json/.test(contentType)) {
            //     error = new Error('无效的 content-type.\n' +
            //         `期望 application/json 但获取的是 ${contentType}`);
            // }
            if (error) {
                console.error(error.message);
                cb({
                    status: -1,
                    message: error.message
                })
                // 消耗响应数据以释放内存
                res.resume();
                return;
            }

            res.setEncoding('utf8');
            let rawData = '';
            res.on('data', (chunk) => { rawData += chunk; });
            res.on('end', () => {
                try {
                    const parsedData = JSON.parse(rawData);
                    cb(rawData)
                } catch (e) {
                    console.error(e.message);
                    cb({
                        status: -1,
                        message: e.message
                    })
                }
            });
        }).on('error', (e) => {
            console.error(`错误: ${e.message}`);
            cb({
                status: -1,
                message: e.message
            })
        });
    },
    httpPost: function(url, args, cb) {
        // console.log(args)
        var url = URL.parse(url)
        args = JSON.stringify(args)
        console.log(url)
        const options = {
            hostname: url.hostname,
            // port: 80,
            path: url.path,
            method: 'GET',
            headers: {
                'Content-Type': 'text/json; charset=utf-8',
                // "content-type":"text/plain; charset=utf-8"
                'Content-Length': Buffer.byteLength(args)
            }
        };

        const req = http.request(options, (res) => {
            console.log(`状态码: ${res.statusCode}`);
            console.log(`响应头: ${JSON.stringify(res.headers)}`);
            res.setEncoding('utf8');
            res.on('data', (chunk) => {

                console.log(`响应主体: ${chunk}`);
            });
            res.on('end', () => {
                console.log('响应中已无数据。');
            });
        });

        req.on('error', (e) => {
            console.error(`请求遇到问题: ${e.message}`);
        });

        // 写入数据到请求主体
        req.write(args);
        req.end();
    }
}

module.exports = fw