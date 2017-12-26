// 复杂的自定义覆盖物
function ComplexCustomOverlay(map, point, text) {
    this._map = map
    this._point = point;
    this._text = text;
}
//继承
ComplexCustomOverlay.prototype = new BMap.Overlay();
//初始化
ComplexCustomOverlay.prototype.initialize = function(map) {
    var div = this._div = document.createElement("div");
    div.style.position = "absolute";
    div.style.zIndex = BMap.Overlay.getZIndex(this._point.lat);
    div.style.backgroundColor = "#fff";
    div.style.color = "#4c4c67";
    div.style.height = "40px";
    div.style.width = "160px";
    div.style.padding = "10px 20px";
    div.style.lineHeight = "40px";
    div.style.whiteSpace = "nowrap";
    div.style.MozUserSelect = "none";
    div.style.boxShadow = "1px 2px 1px rgba(0,0,0,.3)"
    div.style.fontSize = "14px"
    var span = this._span = document.createElement("span");
    span.style.display = "block";
    span.style.fontWeight = "700";
    span.style.textAlign = "center";
    div.appendChild(span);
    span.appendChild(document.createTextNode(this._text));
    var that = this;

    var arrow = this._arrow = document.createElement("div");
    arrow.style.background = "url(http://webmap0.bdimg.com/image/api/tail_shadow2x.png) no-repeat";
    arrow.style.position = "absolute";
    arrow.style.width = "16px";
    arrow.style.height = "10px";
    arrow.style.backgroundSize = "16px 10px";

    arrow.style.top = "60px";
    arrow.style.left = "90px";
    arrow.style.overflow = "hidden";
    div.appendChild(arrow);

    map.getPanes().labelPane.appendChild(div);
    return div;
}
//绘制
ComplexCustomOverlay.prototype.draw = function() {
    var map = this._map;
    var pixel = map.pointToOverlayPixel(this._point);
    this._div.style.left = pixel.x - 98 + "px";
    this._div.style.top = pixel.y - 90 + "px";
}

// 汽车详情覆盖物
function ComplexCarOverlay(map, point, info) {
    this._map = map
    this._point = point;
    this._info = info;
}
//继承
ComplexCarOverlay.prototype = new BMap.Overlay();
//初始化
ComplexCarOverlay.prototype.initialize = function(map) {
    var div = this._div = document.createElement("div");
    div.style.position = "relative";
    div.style.zIndex = "999"
    div.style.backgroundColor = "#fff";
    div.style.color = "#4c4c67";
    div.style.height = "auto";
    div.style.width = "200px";
    div.style.padding = "10px 20px";
    div.style.lineHeight = "40px";
    div.style.whiteSpace = "nowrap";
    div.style.MozUserSelect = "none";
    div.style.boxShadow = "1px 2px 1px rgba(0,0,0,.3)"
    div.style.fontSize = "14px"
    for (var i in this._info) {
        var item = this._info[i]
        var dl = document.createElement("div");
        dl.style.display = "flex"
        dl.style.flexDirection = "colum"
        dl.style.height = "24px"
        dl.style.lineHeight = "24px"
        var title = document.createElement("span")
        title.append(document.createTextNode(item.title + ":"))
        title.style.fontWeight = "700"
        title.style.marginRight = "10px"
        var value = document.createElement("span")
        value.append(document.createTextNode(item.value))
        dl.appendChild(title)
        dl.appendChild(value)
        div.appendChild(dl);
    }
    map.getPanes().labelPane.appendChild(div);
    return div;
}
//绘制
ComplexCarOverlay.prototype.draw = function() {
    var map = this._map;
    var pixel = map.pointToOverlayPixel(this._point);
    this._div.style.left = pixel.x - 120 + "px";
    this._div.style.top = pixel.y + 20 + "px";
}
//输入类
function SearchInput(opts) {
    this.$el = $(opts.el) //DOM
    this.$input = this.$el.find('input') //输入框
    this.$del = this.$el.find('.search-del') //删除图标
    this.$search = this.$el.find('.submit') //搜索按钮
    this.$list = this.$el.find('.list')
    this.url = '/map/search'
    this.initIcons = opts.initIcons
    this.searchBefore = opts.searchBefore
    this.itemMouseover = opts.itemMouseover
    this.itemMouseout = opts.itemMouseout
    this.itemClick = opts.itemClick
    this.clear = opts.clear
}
//初始化
SearchInput.prototype.init = function() {
    this.eventBind()
}
//事件绑定
SearchInput.prototype.eventBind = function() {
    var self = this
    self.$search.on('click', () => {
        $('#way-list').hide()
        self.searchBefore()
        var value = self.$input.val();
        if (!value) {
            self.initIcons([])
            self.$list.html('')
            self.$input.focus()
            return
        }
        // 加载动画
        self.$list.loading()
        // 搜索结果展示
        self.search(value, (data) => {
            if (data.status != -1) {
                var format = '<div class="list-item" data-index="{index}" data-poi="{poi}" data-address="{_name}"><span class="no-{index}"></span><span>{name}</span><span class="little">{address}</span><span class="right">{distance}</span></div>'
                var list = data.result;
                var len = list.length;
                var arrHtml = []
                for (var i = 0; i < len; i++) {
                    if (list[i].uid) {
                        var name = ''
                        if (list[i].name) {
                            name = list[i].name.length > 14 ? list[i].name.substring(0, 12) + '...' : list[i].name
                            var temp = format.replace(/{name}/g, name)
                                .replace(/{address}/g, (list[i].city || '') + (list[i].district || ''))
                                .replace(/{distance}/g, list[i].distance || '')
                                .replace(/{index}/g, i + 1)
                                .replace(/{poi}/g, list[i].location.lat + ',' + list[i].location.lng)
                                .replace(/{_name}/g, list[i].name)
                            arrHtml.push(temp)
                        }
                    } else {
                        list.splice(i, 1)
                        len--;
                        i--;
                    }
                }
                self.$list.html(arrHtml.join(''))
                //统计数量

                self.$list.append('<div class="list-item center"><span class="record">' + _city + '地区搜索到' + len + '条记录</span></div>')
                self.initIcons(list)
            }
        })
    })
    //删除点击事件
    self.$del.on('click', () => {
        self.$input.val('')
        self.$search.trigger('click')
        $('#way-list').hide()
    })
    //回车事件
    self.$input.on('keydown', (e) => {
        if (e.keyCode == 13) {
            self.$search.trigger('click')
        }
    })
    self.$list.on('mouseover', '.list-item', function() {
        var $this = $(this);
        var i = parseInt($this.data('index')) - 1;
        if (!isNaN(i))
            self.itemMouseover(i)
    })
    self.$list.on('mouseout', '.list-item', function() {
        var $this = $(this);
        var i = parseInt($this.data('index')) - 1;
        if (!isNaN(i))
            self.itemMouseout(i)
    })
    self.$list.on('click', '.list-item', function() {
        var $this = $(this);
        var i = parseInt($this.data('index')) - 1;
        var poi = String($this.data('poi'))
        var address = String($this.data('address'))
        if ($this.hasClass('active')) {
            $this.removeClass('active')
            self.clear()
        } else {
            self.$list.find('.list-item').removeClass('active')
            $this.addClass('active');
            self.itemClick(i, poi, address)
        }
    })
}
//搜索
SearchInput.prototype.search = function(value, cb) {
    $.get(this.url, { keyword: value }, function(data) {
        data = JSON.parse(data)
        var points = []
        for (var i in data.result) {
            if (data.result[i].uid != "")
                points.push(data.result[i].location)
        }
        map.map.setViewport(points)
        cb(data)
    })
}
//搜索地图类
function SearchMap(opts) {
    this.el = opts.el
    this.centerCity = opts.city
    this.map;
    this.iconW = 21;
    this.iconH = 33;
    this.selectedMarket;
    this.selected;
    this.locals = []
}
//初始化
SearchMap.prototype.init = function() {
    this.map = new BMap.Map(this.el, { enableMapClick: false })
    this.map.centerAndZoom(this.centerCity, 12)
    //规划边界
    this.getBoundary()
    //可滑动缩放
    this.map.enableScrollWheelZoom(true)
    return this
}
//绘制坐标
SearchMap.prototype.addIcons = function(list) {
    var self = this
    self.locals = []
    for (var i in list) {
        var pt = new BMap.Point(list[i].location.lng, list[i].location.lat);
        var myIcon = new BMap.Icon("http://webmap1.bdimg.com/wolfman/static/common/images/markers_new2x_c1001de.png", new BMap.Size(21, 33));
        myIcon.imageOffset = new BMap.Size(-i * this.iconW, 0)
        myIcon.imageSize = new BMap.Size(300, 300)
        var marker = new BMap.Marker(pt, { icon: myIcon, title: list[i].name }); // 创建标注
        marker.addEventListener('click', function() {
            self.initIcon()
            self.iconChange(this)
            self.selectedMarket = this;
            var myComplex = self.selectedComplex = new ComplexCustomOverlay(self.map, this.getPosition(), this.getTitle().length > 12 ? this.getTitle().substring(0, 10) + '...' : this.getTitle())
            self.map.addOverlay(myComplex)
        })
        this.map.addOverlay(marker);
        this.locals.push(marker);
    }
}
//坐标变色
SearchMap.prototype.iconChange = function(marker, b = true) {
    var point = marker.getPosition()
    var icon = marker.getIcon()
    icon.imageOffset = new BMap.Size(icon.imageOffset.width, b ? -66 : 0)
    marker.setIcon(icon)
}
//清楚已选中坐标
SearchMap.prototype.initIcon = function() {
    if (this.selectedMarket)
        this.iconChange(this.selectedMarket, false)
    if (this.selectedComplex)
        this.map.removeOverlay(this.selectedComplex)
}
//清楚已选中坐标
SearchMap.prototype.initComplex = function() {
    if (this.selectedComplex)
        this.map.removeOverlay(this.selectedComplex)
}
//绘制边界
SearchMap.prototype.getBoundary = function() {
    var self = this;
    var bdary = new BMap.Boundary();
    bdary.get(this.centerCity, function(rs) { //获取行政区域     
        var count = rs.boundaries.length; //行政区域的点有多少个
        if (count === 0) {
            alert('未能获取当前输入行政区域');
            return;
        }
        var pointArray = [];
        for (var i = 0; i < count; i++) {
            var ply = new BMap.Polygon(rs.boundaries[i], { enableMassClear: false, strokeWeight: 3, strokeStyle: "dashed", strokeColor: "#ff0000", fillColor: "" }); //建立多边形覆盖物
            self.map.addOverlay(ply); //添加覆盖物
            pointArray = pointArray.concat(ply.getPath());
        }
    });
}
//地图上的车辆类
function CarsOfMap(opts) {
    this.map = opts.map
    this.dataUrl = opts.url
    this.wsUrl = opts.wsUrl
    this.desPoiUrl = opts.desPoiUrl
    this.drawMatrixs = opts.drawMatrixs
    this.carsData = []
    this.carsMarket = []
    this.carsLabelMarket = []
    this._enumCarIcon = {
        '0': "car_outline.png",
        '1': "car_online.png",
        '2': "car_free.png"
    }
}
//初始化
CarsOfMap.prototype.init = function() {
    var self = this
    self.getData(() => {
        self.initCars()
        self.conSocket(function(data) {
            var type = data.type
            // console.log(data)
            if (type == "carChange") {
                self.carChange(data.result)
            }
        })
    })
    return this;
}
//车辆状态位置改变
CarsOfMap.prototype.carChange = function(data) {
    console.log(data)
    for (var i in data) {
        var carId = data[i].carId
        var markers = this.getMarketsById(carId)
        var marker = markers.carMarket
        var label = markers.carLabel
        // 获取图标
        var icon = marker.getIcon()
        icon.setImageUrl("/images/" + this._enumCarIcon[data[i].flag])
        // 获取坐标
        var prePt = marker.getPosition()
        var nowPt = new BMap.Point(data[i].location.lng, data[i].location.lat);
        this.carsData[markers.index].location = {
            lng: nowPt.lng,
            lat: nowPt.lat
        }
        var Y = nowPt.lng - prePt.lng
        var X = nowPt.lat - prePt.lat
        var tan = Y / X
        var rota = Math.atan(tan) * 180 - 90
        if (Y < 0) {
            rota = Math.atan(tan) * 180 - 90 - 180
        } else if (X < 0) {
            rota = Math.atan(tan) * 180 - 90 - 180
        }

        // if (X < 0) {
        //     if (Y > 0) {
        //         rota = 90 - Math.atan(tan) * 180
        //     } else {
        //         rota = 180 + Math.atan(tan) * 180
        //     }
        // }

        // 设置新坐标
        label.setPosition(nowPt)
        marker.setPosition(nowPt)
        marker.setRotation(rota)
    }
}
//获取carMarket
CarsOfMap.prototype.getMarketsById = function(carId) {
    for (var i in this.carsData) {
        var temp = this.carsData[i]
        if (temp.carId == carId) {
            return { carMarket: this.carsMarket[i], carLabel: this.carsLabelMarket[i], index: i }
        }
    }
}
//初始化获取车辆数据
CarsOfMap.prototype.getData = function(cb) {
    var self = this
    $.get(self.dataUrl, function(data) {
        self.carsData = data
        cb()
    })
}
//socket建立连接
CarsOfMap.prototype.conSocket = function(cb) {
    var self = this
    this.ws = new WebSocket(this.wsUrl);
    this.ws.onmessage = function(e) {
        cb(JSON.parse(e.data));
    };
    this.ws.onerror = function(err) {
        console.log('_error');
        console.log(err);
    };
    this.ws.onopen = function() {
        console.log('_connect')
        // var obj = {a:1}
        // self.socketSend(JSON.stringify(obj))
    };
    this.ws.onclose = function() {
        console.log('_close');
    };
}

//socket信息发送
CarsOfMap.prototype.socketSend = function(data) {
    this.ws.send(data);
}
//绘制地图上的车辆
CarsOfMap.prototype.initCars = function() {
    var self = this
    var list = self.carsData
    for (var i in list) {
        var pt = new BMap.Point(list[i].location.lng, list[i].location.lat);
        var myIcon = new BMap.Icon("/images/" + self._enumCarIcon[list[i].flag], new BMap.Size(24, 24));
        myIcon.imageSize = new BMap.Size(24, 24)
        var marker = new BMap.Marker(pt, { icon: myIcon, title: list[i].carName }); // 创建标注
        var label = new BMap.Label(list[i].carId, {
            position: pt, // 指定文本标注所在的地理位置
            offset: new BMap.Size(-31, 10)
        })
        label.setStyle({
            color: "#d81e06",
            fontSize: "12px",
            height: "20px",
            lineHeight: "20px",
            width: "60px",
            textAlign: "center",
            border: "none",
            backgroundColor: "transparent"
        });
        marker.addEventListener('mouseover', function() {
            self.selectedMarket = this;
            var info = [{
                title: "名称",
                value: list[i].carId
            }, {
                title: "单位",
                value: list[i].org
            }, {
                title: "牌照",
                value: list[i].carName
            }, {
                title: "执行时间",
                value: list[i].time
            }, {
                title: "更新时间",
                value: list[i].update
            }]
            var myComplex = self.selectedComplex = new ComplexCarOverlay(self.map, this.getPosition(), info)
            self.map.addOverlay(myComplex)
        })
        marker.addEventListener('mouseout', function() {
            self.map.removeOverlay(self.selectedComplex)
        })
        self.map.addOverlay(marker);
        self.map.addOverlay(label);
        self.carsMarket.push(marker);
        self.carsLabelMarket.push(label);
    }
}
//规划汽车路线
CarsOfMap.prototype.routematrix = function(poi, address) {
    $('#way-list').show()
    $('#way-list .list').empty().loading()
    var self = this
    var orgPois = []
    for (var i in self.carsData) {
        orgPois.push(self.carsData[i].location.lat + ',' + self.carsData[i].location.lng)
    }
    $.get(self.desPoiUrl, { desPoi: poi, orginPoi: orgPois.join('|') }, function(data) {
        data = JSON.parse(data)
        if (data.status == 0) {
            var result = data.result
            self.drawMatrixs(result, self.carsData, { name: address, poi: poi })
        } else {
            alert(data.message)
        }
    })
}

function WayLine(opts) {
    this.$el = $(opts.el)
    this.$list = this.$el.find('.list')

}
// 路线初始化
WayLine.prototype.init = function() {
    this.eventBind()
    return this
}
WayLine.prototype.eventBind = function() {
    this.$list.on('click', '.way-item', function(){
        var $this = $(this)
        var orginPoi = $this.data('orgin').split(',')
        var desPoi = $this.data('des').split(',')
        var p1 = new BMap.Point(orginPoi[0], orginPoi[1]);
        var p2 = new BMap.Point(desPoi[1], desPoi[0]);

        var driving = new BMap.DrivingRoute(map.map, { renderOptions: { map: map.map, autoViewport: true } });
        driving.search(p1, p2);

    })
}
WayLine.prototype.draw = function(data, cars, address) {
    var formatHtml = '<div class="way-item" data-orgin="{orginPoi}" data-des="{desPoi}"><span class="iconfont icon-luxian"></span><span class="orgin">{orgin}</span><span class="iconfont icon-arrow"></span><span class="des">{des}</span><span class="distance">{distance}</span><span class="time">{time}</span></div>'
    var html = []
    for (var i in data) {
        var item = data[i]
        var car = cars[i]
        html.push(formatHtml.replace(/{orgin}/g, car.carId)
            .replace(/{des}/g, address.name)
            .replace(/{distance}/g, item.distance.text)
            .replace(/{time}/g, item.duration.text)
            .replace(/{orginPoi}/g, car.location.lng + ',' + car.location.lat)
            .replace(/{desPoi}/g, address.poi)
        )
    }
    this.$list.empty().append(html.join(''))
    this.$list.loading(false)
}

var _city = $('#city').val()
// 初始化地图
var map = new SearchMap({
    el: 'container',
    city: _city
}).init()

var ways = new WayLine({
    el: '#way-list'
}).init()

//初始化汽车数据
var cars = new CarsOfMap({
    map: map.map,
    url: '/map/getCars',
    wsUrl: 'ws://localhost:3000',
    desPoiUrl: '/map/routematrix',
    drawMatrixs: function(data, cars, address) {
        ways.draw(data, cars, address)
    }
}).init()

//搜索框初始化
new SearchInput({
    el: '#search',
    initIcons: function(list) {
        map.addIcons.call(map, list)
    },
    searchBefore: function() {
        if (map.selectedComplex) {
            map.map.removeOverlay(map.selectedComplex)
        }
        for (var i in map.locals) {
            var overlay = map.locals[i]
            map.map.removeOverlay(overlay)
        }
    },
    itemMouseover: function(i) {
        map.iconChange(map.locals[i]);
    },
    itemMouseout: function(i) {
        map.iconChange(map.locals[i], false);
    },
    itemClick: function(i, poi, address) {
        map.initIcon.call(map)
        map.locals[i].V.click();

        //规划汽车路线
        cars.routematrix(poi, address)
    },
    clear: function() {
        map.initComplex()
    }
}).init()