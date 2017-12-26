var mapSearch = (function() {
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

    /* el, searchClick*/
    function MapSearch(opts) {
        this.opts = opts
        this.$el = $(opts.el)
        this.listFormat = '<div class="list-item" data-index="{index}" data-poi="{poi}" data-address="{_name}"><span class="no-{index}"></span><span>{name}</span><span class="little">{address}</span><span class="right">{distance}</span></div>'
        this.searchAPI = '/map/search'
    }

    MapSearch.prototype.init = function() {
        this.initView()
        this.eventBind()
        return this
    }

    MapSearch.prototype.initView = function() {
        this.$el.html('<div class="search"><input type="text" placeholder="搜位置、地点"><span class="iconfont icon-shanchu search-del"></span><button class="btn submit iconfont icon-sousuo"></button></div><div class="list"></div>')
        this.$input = this.$el.find('input') //输入框
        this.$del = this.$el.find('.search-del') //删除图标
        this.$search = this.$el.find('.submit') //搜索按钮
        this.$list = this.$el.find('.list') //搜索结果
    }

    MapSearch.prototype.eventBind = function() {
        var self = this
        self.$search.on('click', () => {
            // $('#way-list').hide() -> searchClick
            typeof self.opts.searchClick == 'function' && self.opts.searchClick()
            //清空
            self.clear()
            var value = self.$input.val();
            if (!value) {
                self.addIcons([])
                self.$list.html('')
                self.$input.focus()
                return
            }
            // 加载动画
            self.$list.loading()
            // 搜索结果展示
            self.search(value, (data) => {
                if (data.status != -1) {
                    // var format = '<div class="list-item" data-index="{index}" data-poi="{poi}" data-address="{_name}"><span class="no-{index}"></span><span>{name}</span><span class="little">{address}</span><span class="right">{distance}</span></div>'
                    var list = data.result;
                    var len = list.length;
                    var arrHtml = []
                    for (var i = 0; i < len; i++) {
                        if (list[i].uid) {
                            var name = ''
                            if (list[i].name) {
                                name = list[i].name.length > 14 ? list[i].name.substring(0, 12) + '...' : list[i].name
                                var temp = self.listFormat.replace(/{name}/g, name)
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
                    self.addIcons(list)
                }
            })
        })
        //删除点击事件
        self.$del.on('click', () => {
            self.$input.val('')
            self.$search.trigger('click')
            typeof self.opts.delClick == 'function' && self.opts.delClick()
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
                self.iconChange(self.locals[i])
        })
        self.$list.on('mouseout', '.list-item', function() {
            var $this = $(this);
            var i = parseInt($this.data('index')) - 1;
            if (!isNaN(i))
                self.iconChange(self.locals[i], false)
        })
        self.$list.on('click', '.list-item', function() {
            var $this = $(this);
            var i = parseInt($this.data('index')) - 1;
            var poi = String($this.data('poi'))
            var address = String($this.data('address'))
            if ($this.hasClass('active')) {
                $this.removeClass('active')
                if (self.selectedComplex)
                    map.removeOverlay(self.selectedComplex)
            } else {
                self.$list.find('.list-item').removeClass('active')
                $this.addClass('active');
                self.locals[i].V.click();
                var arr = poi.split(',')
                map.setCenter(new BMap.Point(arr[1], arr[0]))
                typeof self.opts.itemClick == 'function' && self.opts.itemClick(i, poi, address)
            }
        })
    }
    //调用搜索接口
    MapSearch.prototype.search = function(value, cb) {
        $.get(this.searchAPI, { keyword: value }, function(data) {
            data = JSON.parse(data)
            var points = []
            for (var i in data.result) {
                if (data.result[i].uid != "")
                    points.push(data.result[i].location)
            }
            map.setViewport(points)
            cb(data)
        })
    }

    MapSearch.prototype.addIcons = function(list) {
        var self = this
        self.locals = []
        for (var i in list) {
            var pt = new BMap.Point(list[i].location.lng, list[i].location.lat);
            var myIcon = new BMap.Icon("http://webmap1.bdimg.com/wolfman/static/common/images/markers_new2x_c1001de.png", new BMap.Size(21, 33));
            myIcon.imageOffset = new BMap.Size(-i * 21, 0)
            myIcon.imageSize = new BMap.Size(300, 300)
            var marker = new BMap.Marker(pt, { icon: myIcon, title: list[i].name }); // 创建标注
            marker.index = i
            marker.addEventListener('click', function() {
                self.initIcon()
                self.iconChange(this)
                self.selectedMarket = this;
                var myComplex = self.selectedComplex = new ComplexCustomOverlay(map, this.getPosition(), this.getTitle().length > 12 ? this.getTitle().substring(0, 10) + '...' : this.getTitle())
                map.addOverlay(myComplex)
                self.$list.find('.list-item').removeClass('active')
                self.$list.find('.list-item').eq(this.index).addClass('active');
            })
            map.addOverlay(marker);
            this.locals.push(marker);
        }
    }

    //清楚已选中坐标
    MapSearch.prototype.initIcon = function() {
        if (this.selectedMarket)
            this.iconChange(this.selectedMarket, false)
        if (this.selectedComplex)
            map.removeOverlay(this.selectedComplex)
    }
    //坐标变色
    MapSearch.prototype.iconChange = function(marker, b = true) {
        var point = marker.getPosition()
        var icon = marker.getIcon()
        icon.imageOffset = new BMap.Size(icon.imageOffset.width, b ? -66 : 0)
        marker.setIcon(icon)
    }

    MapSearch.prototype.clear = function() {
        if (this.selectedComplex) {
            map.removeOverlay(this.selectedComplex)
        }
        for (var i in this.locals) {
            var overlay = this.locals[i]
            map.removeOverlay(overlay)
        }
    }

    return new MapSearch({
        el: '#search',
        searchClick: function() {

        },
        itemClick: function(i, pos, address) {

        }
    }).init()
})()