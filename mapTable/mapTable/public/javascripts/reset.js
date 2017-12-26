//对象继承
function extend(format, obj) {
    var result = {}
    for (var i in format) {
        result[i] = format[i]
    }
    for (var j in obj) {
        result[j] = obj[j]
    }
    return result
}
//加载效果
$.fn.loading = function(b = true) {
    var $el = $(this)
    if (b)
        $el.append('<div class="spinner"><div class="dot1"></div><div class="dot2"></div></div>')
    else
        $el.find('.spinner').remove()
};

// 绘制边界
function getBoundary() {
    var bdary = new BMap.Boundary();
    bdary.get(_city, function(rs) { //获取行政区域     
        var count = rs.boundaries.length; //行政区域的点有多少个
        if (count === 0) {
            alert('未能获取当前输入行政区域');
            return;
        }
        // var pointArray = [];
        for (var i = 0; i < count; i++) {
            var ply = new BMap.Polygon(rs.boundaries[i], { enableMassClear: false, strokeWeight: 3, strokeStyle: "dashed", strokeColor: "#ff0000", fillColor: "" }); //建立多边形覆盖物
            map.addOverlay(ply); //添加覆盖物
        }
    });
}
// GCJ-02(火星)转BD-09（百度地图）
function MapabcEncryptToBdmap(gg_lat, gg_lon) {
    var point = new Object();
    var x_pi = 3.14159265358979324 * 3000.0 / 180.0;
    var x = new Number(gg_lon);
    var y = new Number(gg_lat);
    var z = Math.sqrt(x * x + y * y) + 0.00002 * Math.sin(y * x_pi);
    var theta = Math.atan2(y, x) + 0.000003 * Math.cos(x * x_pi);
    var bd_lon = z * Math.cos(theta) + 0.0065;
    var bd_lat = z * Math.sin(theta) + 0.006;
    point.lng = bd_lon;
    point.lat = bd_lat;
    return point;
}
// WGS84(地球坐标系)转BD-09(百度坐标系)
function GPSToBaidu(lngX, latY) {
    var gps_point = new BMap.Point(lngX, latY);
    BMap.Convertor.translate(gps_point, 0, function(bd_point) {
        alert("lng:" + bd_point.lng + " lat:" + bd_point.lat);
    });
}
// BD-09（百度地图）转 GCJ-02(火星)
function BdmapEncryptToMapabc(bd_lat, bd_lon) {
    var point = new Object();
    var x_pi = 3.14159265358979324 * 3000.0 / 180.0;
    var x = new Number(bd_lon - 0.0065);
    var y = new Number(bd_lat - 0.006);
    var z = Math.sqrt(x * x + y * y) - 0.00002 * Math.sin(y * x_pi);
    var theta = Math.atan2(y, x) - 0.000003 * Math.cos(x * x_pi);
    var Mars_lon = z * Math.cos(theta);
    var Mars_lat = z * Math.sin(theta);
    point.lng = Mars_lon;
    point.lat = Mars_lat;
    return point;
}
Math.randomString = function(n) {
    var text = "";
    var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    for (var i = 0; i < n; i++)
        text += possible.charAt(Math.floor(Math.random() * possible.length));

    return text;
};