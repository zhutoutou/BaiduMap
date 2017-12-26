var express = require('express');
var package = require("../package.json");
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res, next) {
    res.render('index', { title: '地图台', city: package.city });
});

module.exports = router;