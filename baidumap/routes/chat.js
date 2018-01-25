var express = require('express');
var package = require('../package.json');
var router = express.Router();

/* GET home page. */
router.get('/',function(req,res,next){
  res.render('chat',{title:'^(*￣(oo)￣)^聊天室'});
});

module.exports = router;