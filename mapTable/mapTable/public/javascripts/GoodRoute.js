var GoodRoute = (function() {
    function GoodRoute(opts) {
        this.opts = opts
        this.$el = $("#way-list")
        this.$del = this.$el.find('.list-del')
        this.$arrow = this.$el.find('.list-arrow')
        this.$list = this.$el.find('.list')
    }
    // 路线初始化
    GoodRoute.prototype.init = function() {
        this.driving = new BMap.DrivingRoute(map, {
            renderOptions: { map: map, autoViewport: true },
            onSearchComplete: function(results) {
                var path = results.getPlan(0).getRoute(0).getPath()
                console.log(path)
            }
        });
        this.eventBind()
        return this
    }
    GoodRoute.prototype.eventBind = function() {
        var self = this;
        this.$list.on('click', '.way-item', function() {
            var $this = $(this)
            self.$list.find('.way-item').removeClass('active')
            $this.addClass('active')
            var orginPoi = $this.data('orgin').split(',')
            var desPoi = $this.data('des').split(',')
            var p1 = new BMap.Point(orginPoi[0], orginPoi[1]);
            var p2 = new BMap.Point(desPoi[1], desPoi[0]);
            // 清理路线
            self.driving.clearResults();
            // 规划路线
            self.driving.search(p1, p2);
        })

        this.$del.on('click', function() {
            self.$el.hide()
        })

    }

    GoodRoute.prototype.draw = function(data, cars, address) {
        // var formatHtml = '<div class="way-item" data-orgin="{orginPoi}" data-des="{desPoi}"><span class="iconfont icon-luxian"></span><span class="orgin">{orgin}</span><span class="iconfont icon-arrow"></span><span class="des">{des}</span><span class="distance">{distance}</span><span class="time">{time}</span></div>'
        var formatHtml = '<div class="way-item" data-orgin="{orginPoi}" data-des="{desPoi}"><span class="iconfont icon-luxian"></span><span class="orgin">{orgin}</span><span class="distance">{distance}</span><span class="time">{time}</span><span class="sign"></span></div>'
        var html = []
        // 路程最短索引
        var minSi = 0; 
        var minTi = 0;
        for (var i in data) {
            var item = data[i]
            var car = cars[i]
            if(item.duration.value < data[minTi].duration.value){
                minTi = i
            }
            html.push(formatHtml.replace(/{orgin}/g, car.carId)
                .replace(/{des}/g, address.name)
                .replace(/{distance}/g, item.distance.text)
                .replace(/{time}/g, item.duration.text)
                .replace(/{orginPoi}/g, car.location.lng + ',' + car.location.lat)
                .replace(/{desPoi}/g, address.poi)
            )
        }
        var list = $("#way-list").find('.list')
        list.loading(false)
        list.empty().append(html.join(''))
        $("#way-list").find('.list .way-item').eq(minSi).find('.sign').append('<span class="minS">近</span>')
        $("#way-list").find('.list .way-item').eq(minTi).find('.sign').append('<span class="minT">快</span>')
    }

    GoodRoute.prototype.clear = function() {
        this.$el.hide()
        this.driving.clearResults();
    }
    return GoodRoute
})()