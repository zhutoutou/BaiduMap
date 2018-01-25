var express = require('express');
var package = require('../package.json');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res, next) {
  res.render('index', { title: package.appsetting.title ,city:package.appsetting.city,ak:package.appsetting.ak});
});

module.exports = router;
