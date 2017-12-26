// 获取城市
var _city = $('#city').val()
// 绘制地图
var map = new BMap.Map('container', { enableMapClick: false })
// 设置地图中心点
map.centerAndZoom(_city, 12)
// 可滑动缩放
map.enableScrollWheelZoom(true)

// 绘制边界
getBoundary()

// 初始化显示车辆
carsInMap = new CarsInMap().init()
// 初始化推荐路线
goodRoute = new GoodRoute().init()
// 实现绘制推荐路线方法
carsInMap.opts.drawRoutes = goodRoute.draw
// 实现ws触发函数 车辆状态改变
ws.bll.carChange = function(data) {
    carsInMap.carChange.call(carsInMap, data)
}
ws.bll.sos = function(data) {
    var position = JSON.parse(data.position)
    lobibox.notify({
        title: '微信报警',
        class: 'info',
        msg: '电话：' + data.phone + '，位置：' + data.address + '，坐标：(' + position.lng + ',' + position.lat + ')',
        data: position.lat + ',' + position.lng + '|' + data.address
    })
}
lobibox.btnClick = function(data) {
    var arr = data.split('|')
    var poi = arr[0]
    var address = arr[1]

    var p = poi.split(',')
    // 坐标转化
    var point = MapabcEncryptToBdmap(p[0], p[1])
    // 添加标记
    var marker = new BMap.Marker(point);
    map.addOverlay(marker);
    // 计算路线
    carsInMap.routematrix(point.lat + ',' + point.lng, address)
}
// 搜索结果点击事件
mapSearch.opts.itemClick = function(i, poi, address) {
    // 计算车路线
    carsInMap.routematrix(poi, address)
}

mapSearch.opts.delClick = function() {
    // 清楚推荐路线
    goodRoute.clear()
}
// var i = 1
// var timer = setInterval(function() {
//     if (i == 5) {
//         clearInterval(timer)
//     }
//     lobibox.notify({
//         title: '微信报警' + i++,
//         class: 'info',
//         msg: '电话：18112068567，位置：南京市雨花台区，坐标：（102.0201212,23212.121234'
//     })
// }, 1000)