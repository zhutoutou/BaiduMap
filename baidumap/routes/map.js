var express = require('express');
var package =require('../package.json');
var fw = require('../framework/framework');
var router = express.Router();

/*GET*/
//获取关键字推荐
router.get('/suggestion', function(req, res, next) {
    
    var url = "http://api.map.baidu.com/place/v2/suggestion?query=" + req.query.keyword + "&region=" + package.appsetting.city + "&city_limit=true&output=json&ak=" + package.appsetting.ak;
    fw.httpGet(url, function(data) {
        res.send(data);
    })
})

//查询关键字
router.get('/search', function(req, res, next) {
    console.log(req.query.keyword)
    var url = "http://api.map.baidu.com/place/v2/search?query=" + req.query.keyword + "&region=" + package.appsetting.city + "&city_limit=true&output=json&ak=" + package.appsetting.ak;
    fw.httpGet(url, function(data) {
        res.send(data);
    })
})
module.exports = router;