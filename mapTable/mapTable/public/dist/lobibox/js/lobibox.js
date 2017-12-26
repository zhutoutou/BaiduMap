var lobibox = (function() {
    function Lobibox(opts) {
        this.$el = $(opts.el);
        this.opts = opts
        var item = {
            id: '11',
            title: '微信报警',
            class: 'info',
            msg: '电话：18112068567，位置：南京市雨花台区，坐标：（102.0201212,23212.121234',
            data:'1,1'
        }
        this.data = [];
        this.event = false;
        this.index = 0;
        this.btnClick = opts.btnClick;
        this.templateTab = '<span data-id="{id}" class="iconfont icon-{class}"></span>'
        this.templateContent = '<div class="tab-content animated-fast zoomIn {class}"><div data-id="{id}" class="lobibox-clear"><span class="iconfont icon-shanchu"></span></div><div class="lobibox-left"><span class="iconfont icon-{class}"></span><span class="btns"><div class="lobibox-btn" data-args="{data}">派车</div></span></div><div class="lobibox-right"><div class="lobibox-title">{title}</div><div class="lobibox-msg">{msg}</div></div></div>'
        return this
    }

    Lobibox.prototype.notify = function(item) {
        this.$el = $(this.opts.el)
        if (!this.event) {
            this.eventBind()
        }
        item.id = Math.randomString(5)
        this.data.push(item)
        this.index = this.data.length - 1
        this.initView()
    }

    Lobibox.prototype.eventBind = function() {
        var self = this
        this.event = true;
        this.$el.on('click', '.box-tab .tabs span', function() {
            var id = $(this).data('id')
            var i = self.findIndexOfTab(id)
            if (i == -1) {
                console.log(id + '未找到')
                return false
            }
            self.index = i
            self.initView()
        })
        this.$el.on('click', '.lobibox-clear', function() {
            var id = $(this).data('id')
            var i = self.findIndexOfTab(id)
            if (i == -1) {
                console.log(id + '未找到')
                return false
            }
            self.index = i
            self.data.splice(self.index, 1)

            self.index = self.data.length - 1
            self.initView();

        })

        this.$el.on('click', '.lobibox-btn', function() {
            var data = $(this).data('args')
            typeof self.btnClick == 'function' && self.btnClick(data)
        })
    }

    Lobibox.prototype.findIndexOfTab = function(id) {
        for (var i in this.data) {
            if (this.data[i].id == id) {
                return i
            }
        }
        return -1
    }

    Lobibox.prototype.initView = function() {
        this.$el.empty()
        if (this.data.length) {
            var tab = $('<div class="box-tab"></div>')
            var tabItem = []
            for (var i in this.data) {
                var item = this.data[i]
                tabItem.push(this.templateTab
                    .replace(/{class}/g, item.class + (i == this.index ? ' active' : ''))
                    .replace(/{id}/g, item.id))
            }
            var item = this.data[this.index]
            tab.append('<div class="tabs">' + tabItem.join('') + '</div>')
            var content = this.templateContent
                .replace(/{class}/g, item.class)
                .replace(/{id}/g, item.id)
                .replace(/{title}/g, item.title)
                .replace(/{msg}/g, item.msg)
                .replace(/{data}/g,item.data);
            this.$el.append(tab).append(content)
        }
    }

    return new Lobibox({
        el: '#lobibox',
        btnClick: function(data) {
            console.log(data)
        }
    })

})()