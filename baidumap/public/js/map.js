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
    anchor:BMAP_ANCHOR_BOTTOM_RIGHT
}));
map.setCurrentCity(this.city); // 设置地图显示的城市 此项是必须设置的
map.enableScrollWheelZoom(true);

$('#search_input').on('input propertychange',function(){
  $.get('/map/suggestion',{keyword:$('#search_input').val()},function(res){
    console.log(res);
  })
})
// 百度地图API功能