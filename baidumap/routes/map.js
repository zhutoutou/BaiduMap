var express = require('express');
var package =require('../package.json');
var fw = require('../framework/framework');
var router = express.Router();

/*GET*/
//获取关键字推荐
router.get('/suggestion', function(req, res, next) {
    console.log('进入')
    var options = {
        url:"http://api.map.baidu.com/place/v2/suggestion",
        param:{
            query:req.query.keyword,
            region: package.appsetting.city,
            city_limit:true,
            output:'json',
            ak:package.appsetting.ak
        }
    }
    try{
        var data = fw.httpGet(options)
        console.log(data);
        res.send(data);
    }
    catch(error){
        console.log(error)
    }
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