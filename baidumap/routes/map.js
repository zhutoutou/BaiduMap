const express = require('express');
const package =require('../package.json');
const fw = require('../framework/framework');
const router = express.Router();
const co = require('co')

/*GET*/
//获取关键字推荐
router.get('/suggestion', function(req, res, next) {
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
    
    co(function* (){
        var result =yield fw.httpGet(options);
        res.send(result.text)
    }).catch(function(err){
        console.log(err)
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