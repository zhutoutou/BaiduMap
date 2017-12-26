var WebSocket = require('ws');
var wss;

var createWss = function(server) {
    wss = new WebSocket.Server({ server });
    //广播
    wss.broadcast = function(message) {
        wss.clients.forEach(function(client) {
            client.send(message);
        });
    };

    wss.on('connection', function connection(ws, req) {

        ws.on('message', function(message) {
            var data = JSON.parse(message)
            console.log(data);
        });

        ws.on('close', function() {
            console.log('_close');
        })

        ws.on('error', function() {
            console.log('_error')
        })

        console.log('在线人数:' + wss.clients.size)
    });
}

var broadcast = function(message) {
    wss && wss.broadcast(message)
}

module.exports = {
    createWss:createWss,
    broadcast:broadcast
}