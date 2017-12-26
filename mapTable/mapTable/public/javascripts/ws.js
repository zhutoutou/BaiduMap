var wsUrl = "ws://localhost:3000"
ws = new WebSocket(wsUrl);
//业务对象
ws.bll = {}
ws.onmessage = function(e) {
    var data = JSON.parse(e.data)
    var type = data.type
    var result = data.result
    typeof ws.bll[type] == 'function' && ws.bll[type](result)
};
ws.onerror = function(err) {
    console.log('_error');
    console.log(err);
};
ws.onopen = function() {
    console.log('_connect')
    // var obj = {a:1}
    // self.socketSend(JSON.stringify(obj))
};
ws.onclose = function() {
    console.log('_close');
};