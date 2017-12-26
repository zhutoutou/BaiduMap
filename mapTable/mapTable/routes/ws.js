var express = require('express');
var wss = require('../bin/wss.js');
var router = express.Router();

/* GET home page. */
router.get('/sos', function(req, res, next) {
    var args = req.query
    console.log(args)
    var data = {
        type: 'sos',
        result: args
    }
    // 转发
    wss.broadcast(JSON.stringify(data))
});

module.exports = router;