var CarsInMap = (function() {
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

    //地图上的车辆类
    function CarsInMap(opts = {
        url: '/map/getCars',
        desPoiUrl: '/map/routematrix',
        drawRoutes: function(data, cars, address) {
            // ways.draw(data, cars, address)
        }
    }) {
        this.opts = opts
        this.dataUrl = opts.url
        this.desPoiUrl = opts.desPoiUrl
        this.drawRoutes = opts.drawRoutes
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
    CarsInMap.prototype.init = function() {
        var self = this
        self.getData(() => {
            self.initCars()
        })
        return this;
    }
    //车辆状态位置改变
    CarsInMap.prototype.carChange = function(data) {
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
    CarsInMap.prototype.getMarketsById = function(carId) {
        for (var i in this.carsData) {
            var temp = this.carsData[i]
            if (temp.carId == carId) {
                return { carMarket: this.carsMarket[i], carLabel: this.carsLabelMarket[i], index: i }
            }
        }
    }
    //初始化获取车辆数据
    CarsInMap.prototype.getData = function(cb) {
        var self = this
        $.get(self.dataUrl, function(data) {
            self.carsData = data
            cb()
        })
    }

    //绘制地图上的车辆
    CarsInMap.prototype.initCars = function() {
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
            marker.carInfo = list[i]
            marker.addEventListener('mouseover', function() {
                self.selectedMarket = this;
                var data = this.carInfo
                var info = [{
                    title: "名称",
                    value: data.carId
                }, {
                    title: "单位",
                    value: data.org
                }, {
                    title: "牌照",
                    value: data.carName
                }, {
                    title: "执行时间",
                    value: data.time
                }, {
                    title: "更新时间",
                    value: data.update
                }]
                var myComplex = self.selectedComplex = new ComplexCarOverlay(map, this.getPosition(), info)
                map.addOverlay(myComplex)
            })
            marker.addEventListener('mouseout', function() {
                map.removeOverlay(self.selectedComplex)
            })
            map.addOverlay(marker);
            map.addOverlay(label);
            self.carsMarket.push(marker);
            self.carsLabelMarket.push(label);
        }
    }
    //规划汽车路线
    CarsInMap.prototype.routematrix = function(poi, address) {
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
                var result = self.sortRoutes(data.result)
                typeof self.opts.drawRoutes == 'function' && self.opts.drawRoutes(result, self.carsData, { name: address, poi: poi })
            } else {
                alert(data.message)
            }
        })
    }
    // 路线排序
    CarsInMap.prototype.sortRoutes = function(data) {
        var compare = function(obj1, obj2) {
            var val1 = obj1.distance.value;
            var val2 = obj2.distance.value;
            if (val1 < val2) {
                return -1;
            } else if (val1 > val2) {
                return 1;
            } else {
                return 0;
            }
        }
        return data.sort(compare)
    }
    return CarsInMap
})()