const http = require('http')
const URL = require('url')
const request = require('superagent')
var fw = {
    /*
    */
    
    httpGet:function(options){
        var url = options.url||'';
        var setting = options.setting||{};
        var param = options.param||{};
        var retry = options.retry||3;
        
        var g = gen()
        var result = g.next();

        return result.value.then(function(res){
            return res.text;
        }).then(function(data){
            g.next(data);
        })
        function* gen(){
            var result = yield promise();
            return result;
        }
        
        function promise(){
            return request
                .get(url)                           //Address
                .set(setting)                       //Setting
                .query(param)                       //Param
                .retry(retry,function(err,res){     //retry
                })
        }
        
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