//初始化派生类
var  socket = io();
var derivative = new Derivative();
window.alert = derivative.alert;
var opts = {
    canvas: '#guassian_blur_container',
    blurRadius: 2
};
derivative.init(opts);
//dom操作类
var domhelper = new Domhelper();
// 获取城市
var city = $('#city').val();
// 创建Map实例
var map = new BMap.Map("allmap");
console.log(this.city);
map.centerAndZoom(this.city); // 初始化地图,设置中心点坐标和地图级别
//添加地图类型控件
map.addControl(new BMap.MapTypeControl({
    mapTypes: [
        BMAP_NORMAL_MAP,
        BMAP_HYBRID_MAP
    ]
}));
//添加控件和比例尺
map.addControl(new BMap.ScaleControl({
    anchor: BMAP_ANCHOR_BOTTOM_RIGHT
}));
map.setCurrentCity(this.city); // 设置地图显示的城市 此项是必须设置的
map.enableScrollWheelZoom(true);

 $.get('/map/suggestion', { keyword: "" }, function(res) {
    var resinfo = JSON.parse(res);
    if (resinfo.status == 0) {
        domhelper.createKeywordPanel(resinfo.result);
    } else {
        console.log('获取关键字推荐信息失败.' + resinfo.message);
    }
});

map.addEventListener('tilesloaded',function() {
    $('#allmap .anchorBL').css('display', 'none');

    $('#search_btn').on('click', function() {
        alert('点击！');
    });
    $('#guassian_blur_container').css('display', 'none');
    $('#search_input').on('input propertychange', function() {
        if ($('#search_input').val().trim() != "") {
            $.get('/map/suggestion', { keyword: $('#search_input').val() }, function(res) {
                var resinfo = JSON.parse(res);
                if (resinfo.status == 0) {
                    domhelper.createKeywordPanel(resinfo.result);
                } else {
                    console.log('获取关键字推荐信息失败.' + resinfo.message);
                }
            });
        } else {
            domhelper.createKeywordPanel([]);
        }
    });

    $('#searchrestult_panel').on('click', 'li.keyworditem', function(e) {
        console.log(domhelper.data[parseInt($(this).attr('index'))].name);
        $.get('/map/search', { keyword: domhelper.data[parseInt($(this).attr('index'))].name }, function(res) {
            var resinfo = JSON.parse(res);
            if (resinfo.status == 0) {
                domhelper.CreateSearchResultPanel(resinfo.results);
            } else {
                console.log('查询关键字推荐信息失败.' + resinfo.message);
            }
        });
    });
});