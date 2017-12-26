var express = require('express');
var fw = require('../framework/framework.js');
var util = require('util')
var package = require('../package.json');
var carList = require('../testData/carlist.js').carlist
var router = express.Router();
/* GET */
/* 搜索匹配地址信息 */
router.get('/search', function(req, res, next) {
    var query = req.query.keyword
    // console.log(query)
    if (query) {
        //获取地区搜索结果
        var url = 'http://api.map.baidu.com/place/v2/suggestion?region=' + package.city + '&city_limit=true&output=json&ak=0FG8srCNgC7GGBtKWGDVplLdHkwRCyVD&query=' + query
        fw.httpGet(url, function(data) {
            res.send(data)
        })
    }
});

/* GET */
/* 获取车辆列表 */
router.get('/getCars', function(req, res, next) {
    res.send(carList)
});

/* GET */
/* 获取车辆到终点路线 */
router.get('/routematrix', function(req, res, next) {
    var desPoi = decodeURI(req.query.desPoi)
    var orginPoi = decodeURI(req.query.orginPoi)
    if (desPoi && orginPoi) {
        //获取地区搜索结果
        var tempUrl = 'http://api.map.baidu.com/routematrix/v2/driving?output=json&ak=MPkmpM5bovQaHTqyjrdARmG0yanIkdKe&destinations=%s&origins=%s'
        var url = util.format(tempUrl, desPoi, orginPoi)
        fw.httpGet(url, function(data) {
            res.send(data)
        })
    }
});
module.exports = router;