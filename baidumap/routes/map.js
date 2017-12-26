var express = require('express');
var package =require('../package.json');
var fw = require('../framework/framework');
var router = express.Router();

/*GET*/
router.get('/suggestion', function(req, res, next) {
    
    var url = "http://api.map.baidu.com/place/v2/suggestion?query=" + req.query.keyword + "&region=" + package.appsetting.city + "&city_limit=true&output=json&ak=" + package.appsetting.ak;
    console.log(url);
    fw.httpGet(url, function(data) {
        res.send(data);
    })
})

module.exports = router;