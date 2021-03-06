var chat = io();
chat.on('rep message',function(msg){
  $('#message').append(`<li>${msg}</li>`);
});
$('form').submit(function(){
  chat.emit('chat message',$('#m').val());
  $('#m').val('');
  return false;
});var Derivative = (function() {
    var opts = {
        canvas: '',
        blurRadius: 0,

    };

    function init(options) {
        //设置画布属性
        opts.canvas = options.canvas;
        opts.blurRadius = options.blurRadius;
        opts.gusArray = createIntArray(options.blurRadius * 2 + 1, options.blurRadius * 2 + 1);
        opts.guslinearArray = [];
        GetGusWeightArray();
        $(opts.canvas).attr('width', $(document).width());
        $(opts.canvas).attr('height', $(document).height());
        $(opts.canvas).css('display', 'none');
    }

    function alert() {
        //创建背景幕布
        html2canvas(document.body).then(canvas => {
            var ctx = $(opts.canvas).get(0).getContext('2d');
            console.log('开始渲染');
            var date1 = new Date(); //开始时间
            //var ImageData = GusImageData(LowerIQ(canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height())));
            var ImageData = GusImageData(canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height()));
            //var ImageData =canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height());
            var date2 = new Date(); //结束时间
            var date3 = date2.getTime() - date1.getTime(); //时间差的毫秒数
            console.log('结束渲染，用时' + date3);
            ctx.putImageData(ImageData, 0, 0, 0, 0, $(document).width(), $(document).height());
            $(opts.canvas).css('display', 'block');
        });

        //创建一个大盒子
        var box = document.createElement("div");　　 //创建一个关闭按钮
        var button = document.createElement("button");　　 //定义一个对象保存样式
        var boxName = {
            width: "500px",
            height: "180px",
            backgroundColor: "#f8f8f8",
            border: "1px solid #ccc",
            position: "absolute",
            top: "50%",
            left: "50%",
            margin: "-90px 0 0 -250px",
            zIndex: "999",
            textAlign: "center",
            lineHeight: "180px"
        };　　 //给元素添加元素
        for (var k in boxName) {
            box.style[k] = boxName[k];
        }　　 //把创建的元素添加到body中
        document.body.appendChild(box);　　 //把alert传入的内容添加到box中
        if (arguments[0]) {
            box.innerHTML = arguments[0];
        }
        button.innerHTML = "关闭";　　 //定义按钮样式
        var btnName = {
            border: "1px solid #ccc",
            backgroundColor: "#fff",
            width: "70px",
            height: "30px",
            textAlign: "center",
            lineHeight: "30px",
            outline: "none",
            position: "absolute",
            bottom: "10px",
            right: "20px",
        };
        for (var j in btnName) {
            button.style[j] = btnName[j];
        }　　 //把按钮添加到box中
        box.appendChild(button);　　 //给按钮添加单击事件
        button.addEventListener("click", function() {
            box.style.display = "none";
            $(opts.canvas).css('display', 'none');
        });
    }

    function GusImageData(imagedata) {
        var width = imagedata.width;
        var height = imagedata.height;
        var data = new createIntArray(imagedata.data.length, 0);
        var blurRadius = opts.blurRadius;
        if (width < blurRadius * 2 + 1 || height < blurRadius * 2 + 1) {
            console.log('高斯模糊的直接大于长或者宽，不支持');
        } else {
            for (var i = 0; i < imagedata.data.length; i += 4) {

                var Red = 0;
                var Green = 0;
                var Blue = 0;
                var Alpha = 0;
                for (var m = -blurRadius; m < blurRadius + 1; m++) {
                    for (var n = -blurRadius; n < blurRadius + 1; n++) {
                        if (Math.round(i / 4 / width) + m < 0 || Math.round(i / 4 / width) + m > height - 1 || ((i / 4) % width) + n < 0 || ((i / 4) % width) + n > width - 1) {
                            Red = Red + imagedata.data[i] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Green = Green + imagedata.data[i + 1] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Blue = Blue + imagedata.data[i + 2] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Alpha = Alpha + imagedata.data[i + 3] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                        } else {
                            Red = Red + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n)] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Green = Green + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 1] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Blue = Blue + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 2] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Alpha = Alpha + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 3] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                        }
                    }
                }
                data[i] = Math.round(Red);
                data[i + 1] = Math.round(Green);
                data[i + 2] = Math.round(Blue);
                data[i + 3] = Math.round(Alpha);


            }
            var obj = new ImageData(data, imagedata.width, imagedata.height);
            return obj;
        }
    }

    function LowerIQ(imagedata) {
        var y = Math.round(imagedata.height / 10);
        var x = Math.round(imagedata.width / 10);
        var data = createIntArray(x * y * 4, 0);
        for (var m = 0; m < imagedata.height; m += 10) {
            for (var n = 0; n < imagedata.width; n += 10) {
                data[(n / 10 + Math.round(m / 10) * x) * 4] = imagedata.data[(m * imagedata.width + n) * 4];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 1] = imagedata.data[(m * imagedata.width + n) * 4 + 1];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 2] = imagedata.data[(m * imagedata.width + n) * 4 + 2];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 3] = imagedata.data[(m * imagedata.width + n) * 4 + 3];
            }
        }

        var obj = new ImageData(data, x, y);
        return obj;
    }

    function GusImage(image, width, height) {

    }


    function GetGusWeightArray() {
        var blurRadius = opts.blurRadius;
        var gusArray = createIntArray(blurRadius * 2 + 1, blurRadius * 2 + 1);
        var sigam = (blurRadius * 2 + 1) / 2;
        var count = 0;
        for (var y = -blurRadius; y < blurRadius + 1; y++) {
            for (var x = -blurRadius; x < blurRadius + 1; x++) {
                var weight = (1 / (2 * Math.PI * sigam * sigam)) * Math.pow(Math.E, (-(x * x + y * y) / (2 * sigam * sigam)));
                count = count + weight;
                gusArray[y + blurRadius][x + blurRadius] = weight;

            }
        }
        for (var k = 0; k < blurRadius * 2 + 1; k++) {
            for (var m = 0; m < blurRadius * 2 + 1; m++) {
                opts.gusArray[k][m] = gusArray[k][m] / count;
                opts.guslinearArray[k * (blurRadius * 2 + 1) + m] = gusArray[k][m] / count;
            }
        }
    }

    function createIntArray(x, y) {
        var arr ={};
        if (y) {
            arr = [];

            for (var j = 0; j < y; j++) {

                arr[j] = [];
                for (var i = 0; i < x; i++) {
                    arr[j][i] = 0.0;
                }

            }
        } else {
            arr = new Uint8ClampedArray(x);
        }
        return arr;
    }

    return function() {
        this.alert = alert;
        this.init = init;
    };
})();var Domhelper = function() {
    var data = {};

    var createKeywordPanel = function(data) {
        this.data = data;
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display', 'block');
        var ul = $('<ul></ul>');
        for (var i = 0; i < data.length && i < 10; i++) {
            var id = 'keyitem_' + i;
            var index = i;
            var li = $("<li id='" + 'suggestitem_' + i + "' class='suggestitem' index='" + i + "'><a><i class='default'>" + data[i].name + "</i><em>" + data[i].district + "</em></a></li>");

            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);

    };

    var CreateSearchResultPanel = function(data) {
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display', 'block');
        var ul = $('<ul></ul>');
        for (var i = 0; i < data.length && i < 10; i++) {


            var id = 'keyitem_' + i;
            var index = i;
            var li = $("<li id='" + 'keyitem_' + i + "' class='keyworditem' index='" + i + "'><a class='search_item'><i class='search'>" + data[i].name + "</i><em>" + data[i].address + "</em></a></li>");
            // li.on('click', function(e) {
            //     console.log(e);
            // });
            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);
    };

    this.CreateSearchResultPanel = CreateSearchResultPanel;
    this.createKeywordPanel = createKeywordPanel;
    this.data = data;
};//初始化派生类
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
});var chat = io();
chat.on('rep message',function(msg){
  $('#message').append(`<li>${msg}</li>`);
});
$('form').submit(function(){
  chat.emit('chat message',$('#m').val());
  $('#m').val('');
  return false;
});var Derivative = (function() {
    var opts = {
        canvas: '',
        blurRadius: 0,

    };

    function init(options) {
        //设置画布属性
        opts.canvas = options.canvas;
        opts.blurRadius = options.blurRadius;
        opts.gusArray = createIntArray(options.blurRadius * 2 + 1, options.blurRadius * 2 + 1);
        opts.guslinearArray = [];
        GetGusWeightArray();
        $(opts.canvas).attr('width', $(document).width());
        $(opts.canvas).attr('height', $(document).height());
        $(opts.canvas).css('display', 'none');
    }

    function alert() {
        //创建背景幕布
        html2canvas(document.body).then(canvas => {
            var ctx = $(opts.canvas).get(0).getContext('2d');
            console.log('开始渲染');
            var date1 = new Date(); //开始时间
            //var ImageData = GusImageData(LowerIQ(canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height())));
            var ImageData = GusImageData(canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height()));
            //var ImageData =canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height());
            var date2 = new Date(); //结束时间
            var date3 = date2.getTime() - date1.getTime(); //时间差的毫秒数
            console.log('结束渲染，用时' + date3);
            ctx.putImageData(ImageData, 0, 0, 0, 0, $(document).width(), $(document).height());
            $(opts.canvas).css('display', 'block');
        });

        //创建一个大盒子
        var box = document.createElement("div");　　 //创建一个关闭按钮
        var button = document.createElement("button");　　 //定义一个对象保存样式
        var boxName = {
            width: "500px",
            height: "180px",
            backgroundColor: "#f8f8f8",
            border: "1px solid #ccc",
            position: "absolute",
            top: "50%",
            left: "50%",
            margin: "-90px 0 0 -250px",
            zIndex: "999",
            textAlign: "center",
            lineHeight: "180px"
        };　　 //给元素添加元素
        for (var k in boxName) {
            box.style[k] = boxName[k];
        }　　 //把创建的元素添加到body中
        document.body.appendChild(box);　　 //把alert传入的内容添加到box中
        if (arguments[0]) {
            box.innerHTML = arguments[0];
        }
        button.innerHTML = "关闭";　　 //定义按钮样式
        var btnName = {
            border: "1px solid #ccc",
            backgroundColor: "#fff",
            width: "70px",
            height: "30px",
            textAlign: "center",
            lineHeight: "30px",
            outline: "none",
            position: "absolute",
            bottom: "10px",
            right: "20px",
        };
        for (var j in btnName) {
            button.style[j] = btnName[j];
        }　　 //把按钮添加到box中
        box.appendChild(button);　　 //给按钮添加单击事件
        button.addEventListener("click", function() {
            box.style.display = "none";
            $(opts.canvas).css('display', 'none');
        });
    }

    function GusImageData(imagedata) {
        var width = imagedata.width;
        var height = imagedata.height;
        var data = new createIntArray(imagedata.data.length, 0);
        var blurRadius = opts.blurRadius;
        if (width < blurRadius * 2 + 1 || height < blurRadius * 2 + 1) {
            console.log('高斯模糊的直接大于长或者宽，不支持');
        } else {
            for (var i = 0; i < imagedata.data.length; i += 4) {

                var Red = 0;
                var Green = 0;
                var Blue = 0;
                var Alpha = 0;
                for (var m = -blurRadius; m < blurRadius + 1; m++) {
                    for (var n = -blurRadius; n < blurRadius + 1; n++) {
                        if (Math.round(i / 4 / width) + m < 0 || Math.round(i / 4 / width) + m > height - 1 || ((i / 4) % width) + n < 0 || ((i / 4) % width) + n > width - 1) {
                            Red = Red + imagedata.data[i] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Green = Green + imagedata.data[i + 1] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Blue = Blue + imagedata.data[i + 2] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Alpha = Alpha + imagedata.data[i + 3] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                        } else {
                            Red = Red + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n)] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Green = Green + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 1] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Blue = Blue + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 2] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Alpha = Alpha + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 3] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                        }
                    }
                }
                data[i] = Math.round(Red);
                data[i + 1] = Math.round(Green);
                data[i + 2] = Math.round(Blue);
                data[i + 3] = Math.round(Alpha);


            }
            var obj = new ImageData(data, imagedata.width, imagedata.height);
            return obj;
        }
    }

    function LowerIQ(imagedata) {
        var y = Math.round(imagedata.height / 10);
        var x = Math.round(imagedata.width / 10);
        var data = createIntArray(x * y * 4, 0);
        for (var m = 0; m < imagedata.height; m += 10) {
            for (var n = 0; n < imagedata.width; n += 10) {
                data[(n / 10 + Math.round(m / 10) * x) * 4] = imagedata.data[(m * imagedata.width + n) * 4];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 1] = imagedata.data[(m * imagedata.width + n) * 4 + 1];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 2] = imagedata.data[(m * imagedata.width + n) * 4 + 2];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 3] = imagedata.data[(m * imagedata.width + n) * 4 + 3];
            }
        }

        var obj = new ImageData(data, x, y);
        return obj;
    }

    function GusImage(image, width, height) {

    }


    function GetGusWeightArray() {
        var blurRadius = opts.blurRadius;
        var gusArray = createIntArray(blurRadius * 2 + 1, blurRadius * 2 + 1);
        var sigam = (blurRadius * 2 + 1) / 2;
        var count = 0;
        for (var y = -blurRadius; y < blurRadius + 1; y++) {
            for (var x = -blurRadius; x < blurRadius + 1; x++) {
                var weight = (1 / (2 * Math.PI * sigam * sigam)) * Math.pow(Math.E, (-(x * x + y * y) / (2 * sigam * sigam)));
                count = count + weight;
                gusArray[y + blurRadius][x + blurRadius] = weight;

            }
        }
        for (var k = 0; k < blurRadius * 2 + 1; k++) {
            for (var m = 0; m < blurRadius * 2 + 1; m++) {
                opts.gusArray[k][m] = gusArray[k][m] / count;
                opts.guslinearArray[k * (blurRadius * 2 + 1) + m] = gusArray[k][m] / count;
            }
        }
    }

    function createIntArray(x, y) {
        var arr ={};
        if (y) {
            arr = [];

            for (var j = 0; j < y; j++) {

                arr[j] = [];
                for (var i = 0; i < x; i++) {
                    arr[j][i] = 0.0;
                }

            }
        } else {
            arr = new Uint8ClampedArray(x);
        }
        return arr;
    }

    return function() {
        this.alert = alert;
        this.init = init;
    };
})();var Domhelper = function() {
    var data = {};

    var createKeywordPanel = function(data) {
        this.data = data;
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display', 'block');
        var ul = $('<ul></ul>');
        for (var i = 0; i < data.length && i < 10; i++) {
            var id = 'keyitem_' + i;
            var index = i;
            var li = $("<li id='" + 'suggestitem_' + i + "' class='suggestitem' index='" + i + "'><a><i class='default'>" + data[i].name + "</i><em>" + data[i].district + "</em></a></li>");

            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);

    };

    var CreateSearchResultPanel = function(data) {
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display', 'block');
        var ul = $('<ul></ul>');
        for (var i = 0; i < data.length && i < 10; i++) {


            var id = 'keyitem_' + i;
            var index = i;
            var li = $("<li id='" + 'keyitem_' + i + "' class='keyworditem' index='" + i + "'><a class='search_item'><i class='search'>" + data[i].name + "</i><em>" + data[i].address + "</em></a></li>");
            // li.on('click', function(e) {
            //     console.log(e);
            // });
            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);
    };

    this.CreateSearchResultPanel = CreateSearchResultPanel;
    this.createKeywordPanel = createKeywordPanel;
    this.data = data;
};//初始化派生类
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
});var chat = io();
chat.on('rep message',function(msg){
  $('#message').append(`<li>${msg}</li>`);
});
$('form').submit(function(){
  chat.emit('chat message',$('#m').val());
  $('#m').val('');
  return false;
});var Derivative = (function() {
    var opts = {
        canvas: '',
        blurRadius: 0,

    };

    function init(options) {
        //设置画布属性
        opts.canvas = options.canvas;
        opts.blurRadius = options.blurRadius;
        opts.gusArray = createIntArray(options.blurRadius * 2 + 1, options.blurRadius * 2 + 1);
        opts.guslinearArray = [];
        GetGusWeightArray();
        $(opts.canvas).attr('width', $(document).width());
        $(opts.canvas).attr('height', $(document).height());
        $(opts.canvas).css('display', 'none');
    }

    function alert() {
        //创建背景幕布
        html2canvas(document.body).then(canvas => {
            var ctx = $(opts.canvas).get(0).getContext('2d');
            console.log('开始渲染');
            var date1 = new Date(); //开始时间
            //var ImageData = GusImageData(LowerIQ(canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height())));
            var ImageData = GusImageData(canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height()));
            //var ImageData =canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height());
            var date2 = new Date(); //结束时间
            var date3 = date2.getTime() - date1.getTime(); //时间差的毫秒数
            console.log('结束渲染，用时' + date3);
            ctx.putImageData(ImageData, 0, 0, 0, 0, $(document).width(), $(document).height());
            $(opts.canvas).css('display', 'block');
        });

        //创建一个大盒子
        var box = document.createElement("div");　　 //创建一个关闭按钮
        var button = document.createElement("button");　　 //定义一个对象保存样式
        var boxName = {
            width: "500px",
            height: "180px",
            backgroundColor: "#f8f8f8",
            border: "1px solid #ccc",
            position: "absolute",
            top: "50%",
            left: "50%",
            margin: "-90px 0 0 -250px",
            zIndex: "999",
            textAlign: "center",
            lineHeight: "180px"
        };　　 //给元素添加元素
        for (var k in boxName) {
            box.style[k] = boxName[k];
        }　　 //把创建的元素添加到body中
        document.body.appendChild(box);　　 //把alert传入的内容添加到box中
        if (arguments[0]) {
            box.innerHTML = arguments[0];
        }
        button.innerHTML = "关闭";　　 //定义按钮样式
        var btnName = {
            border: "1px solid #ccc",
            backgroundColor: "#fff",
            width: "70px",
            height: "30px",
            textAlign: "center",
            lineHeight: "30px",
            outline: "none",
            position: "absolute",
            bottom: "10px",
            right: "20px",
        };
        for (var j in btnName) {
            button.style[j] = btnName[j];
        }　　 //把按钮添加到box中
        box.appendChild(button);　　 //给按钮添加单击事件
        button.addEventListener("click", function() {
            box.style.display = "none";
            $(opts.canvas).css('display', 'none');
        });
    }

    function GusImageData(imagedata) {
        var width = imagedata.width;
        var height = imagedata.height;
        var data = new createIntArray(imagedata.data.length, 0);
        var blurRadius = opts.blurRadius;
        if (width < blurRadius * 2 + 1 || height < blurRadius * 2 + 1) {
            console.log('高斯模糊的直接大于长或者宽，不支持');
        } else {
            for (var i = 0; i < imagedata.data.length; i += 4) {

                var Red = 0;
                var Green = 0;
                var Blue = 0;
                var Alpha = 0;
                for (var m = -blurRadius; m < blurRadius + 1; m++) {
                    for (var n = -blurRadius; n < blurRadius + 1; n++) {
                        if (Math.round(i / 4 / width) + m < 0 || Math.round(i / 4 / width) + m > height - 1 || ((i / 4) % width) + n < 0 || ((i / 4) % width) + n > width - 1) {
                            Red = Red + imagedata.data[i] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Green = Green + imagedata.data[i + 1] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Blue = Blue + imagedata.data[i + 2] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Alpha = Alpha + imagedata.data[i + 3] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                        } else {
                            Red = Red + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n)] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Green = Green + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 1] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Blue = Blue + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 2] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Alpha = Alpha + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 3] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                        }
                    }
                }
                data[i] = Math.round(Red);
                data[i + 1] = Math.round(Green);
                data[i + 2] = Math.round(Blue);
                data[i + 3] = Math.round(Alpha);


            }
            var obj = new ImageData(data, imagedata.width, imagedata.height);
            return obj;
        }
    }

    function LowerIQ(imagedata) {
        var y = Math.round(imagedata.height / 10);
        var x = Math.round(imagedata.width / 10);
        var data = createIntArray(x * y * 4, 0);
        for (var m = 0; m < imagedata.height; m += 10) {
            for (var n = 0; n < imagedata.width; n += 10) {
                data[(n / 10 + Math.round(m / 10) * x) * 4] = imagedata.data[(m * imagedata.width + n) * 4];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 1] = imagedata.data[(m * imagedata.width + n) * 4 + 1];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 2] = imagedata.data[(m * imagedata.width + n) * 4 + 2];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 3] = imagedata.data[(m * imagedata.width + n) * 4 + 3];
            }
        }

        var obj = new ImageData(data, x, y);
        return obj;
    }

    function GusImage(image, width, height) {

    }


    function GetGusWeightArray() {
        var blurRadius = opts.blurRadius;
        var gusArray = createIntArray(blurRadius * 2 + 1, blurRadius * 2 + 1);
        var sigam = (blurRadius * 2 + 1) / 2;
        var count = 0;
        for (var y = -blurRadius; y < blurRadius + 1; y++) {
            for (var x = -blurRadius; x < blurRadius + 1; x++) {
                var weight = (1 / (2 * Math.PI * sigam * sigam)) * Math.pow(Math.E, (-(x * x + y * y) / (2 * sigam * sigam)));
                count = count + weight;
                gusArray[y + blurRadius][x + blurRadius] = weight;

            }
        }
        for (var k = 0; k < blurRadius * 2 + 1; k++) {
            for (var m = 0; m < blurRadius * 2 + 1; m++) {
                opts.gusArray[k][m] = gusArray[k][m] / count;
                opts.guslinearArray[k * (blurRadius * 2 + 1) + m] = gusArray[k][m] / count;
            }
        }
    }

    function createIntArray(x, y) {
        var arr ={};
        if (y) {
            arr = [];

            for (var j = 0; j < y; j++) {

                arr[j] = [];
                for (var i = 0; i < x; i++) {
                    arr[j][i] = 0.0;
                }

            }
        } else {
            arr = new Uint8ClampedArray(x);
        }
        return arr;
    }

    return function() {
        this.alert = alert;
        this.init = init;
    };
})();var Domhelper = function() {
    var data = {};

    var createKeywordPanel = function(data) {
        this.data = data;
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display', 'block');
        var ul = $('<ul></ul>');
        for (var i = 0; i < data.length && i < 10; i++) {
            var id = 'keyitem_' + i;
            var index = i;
            var li = $("<li id='" + 'suggestitem_' + i + "' class='suggestitem' index='" + i + "'><a><i class='default'>" + data[i].name + "</i><em>" + data[i].district + "</em></a></li>");

            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);

    };

    var CreateSearchResultPanel = function(data) {
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display', 'block');
        var ul = $('<ul></ul>');
        for (var i = 0; i < data.length && i < 10; i++) {


            var id = 'keyitem_' + i;
            var index = i;
            var li = $("<li id='" + 'keyitem_' + i + "' class='keyworditem' index='" + i + "'><a class='search_item'><i class='search'>" + data[i].name + "</i><em>" + data[i].address + "</em></a></li>");
            // li.on('click', function(e) {
            //     console.log(e);
            // });
            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);
    };

    this.CreateSearchResultPanel = CreateSearchResultPanel;
    this.createKeywordPanel = createKeywordPanel;
    this.data = data;
};//初始化派生类
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
});var chat = io();
chat.on('rep message',function(msg){
  $('#message').append(`<li>${msg}</li>`);
});
$('form').submit(function(){
  chat.emit('chat message',$('#m').val());
  $('#m').val('');
  return false;
});var Derivative = (function() {
    var opts = {
        canvas: '',
        blurRadius: 0,

    };

    function init(options) {
        //设置画布属性
        opts.canvas = options.canvas;
        opts.blurRadius = options.blurRadius;
        opts.gusArray = createIntArray(options.blurRadius * 2 + 1, options.blurRadius * 2 + 1);
        opts.guslinearArray = [];
        GetGusWeightArray();
        $(opts.canvas).attr('width', $(document).width());
        $(opts.canvas).attr('height', $(document).height());
        $(opts.canvas).css('display', 'none');
    }

    function alert() {
        //创建背景幕布
        html2canvas(document.body).then(canvas => {
            var ctx = $(opts.canvas).get(0).getContext('2d');
            console.log('开始渲染');
            var date1 = new Date(); //开始时间
            //var ImageData = GusImageData(LowerIQ(canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height())));
            var ImageData = GusImageData(canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height()));
            //var ImageData =canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height());
            var date2 = new Date(); //结束时间
            var date3 = date2.getTime() - date1.getTime(); //时间差的毫秒数
            console.log('结束渲染，用时' + date3);
            ctx.putImageData(ImageData, 0, 0, 0, 0, $(document).width(), $(document).height());
            $(opts.canvas).css('display', 'block');
        });

        //创建一个大盒子
        var box = document.createElement("div");　　 //创建一个关闭按钮
        var button = document.createElement("button");　　 //定义一个对象保存样式
        var boxName = {
            width: "500px",
            height: "180px",
            backgroundColor: "#f8f8f8",
            border: "1px solid #ccc",
            position: "absolute",
            top: "50%",
            left: "50%",
            margin: "-90px 0 0 -250px",
            zIndex: "999",
            textAlign: "center",
            lineHeight: "180px"
        };　　 //给元素添加元素
        for (var k in boxName) {
            box.style[k] = boxName[k];
        }　　 //把创建的元素添加到body中
        document.body.appendChild(box);　　 //把alert传入的内容添加到box中
        if (arguments[0]) {
            box.innerHTML = arguments[0];
        }
        button.innerHTML = "关闭";　　 //定义按钮样式
        var btnName = {
            border: "1px solid #ccc",
            backgroundColor: "#fff",
            width: "70px",
            height: "30px",
            textAlign: "center",
            lineHeight: "30px",
            outline: "none",
            position: "absolute",
            bottom: "10px",
            right: "20px",
        };
        for (var j in btnName) {
            button.style[j] = btnName[j];
        }　　 //把按钮添加到box中
        box.appendChild(button);　　 //给按钮添加单击事件
        button.addEventListener("click", function() {
            box.style.display = "none";
            $(opts.canvas).css('display', 'none');
        });
    }

    function GusImageData(imagedata) {
        var width = imagedata.width;
        var height = imagedata.height;
        var data = new createIntArray(imagedata.data.length, 0);
        var blurRadius = opts.blurRadius;
        if (width < blurRadius * 2 + 1 || height < blurRadius * 2 + 1) {
            console.log('高斯模糊的直接大于长或者宽，不支持');
        } else {
            for (var i = 0; i < imagedata.data.length; i += 4) {

                var Red = 0;
                var Green = 0;
                var Blue = 0;
                var Alpha = 0;
                for (var m = -blurRadius; m < blurRadius + 1; m++) {
                    for (var n = -blurRadius; n < blurRadius + 1; n++) {
                        if (Math.round(i / 4 / width) + m < 0 || Math.round(i / 4 / width) + m > height - 1 || ((i / 4) % width) + n < 0 || ((i / 4) % width) + n > width - 1) {
                            Red = Red + imagedata.data[i] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Green = Green + imagedata.data[i + 1] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Blue = Blue + imagedata.data[i + 2] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Alpha = Alpha + imagedata.data[i + 3] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                        } else {
                            Red = Red + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n)] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Green = Green + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 1] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Blue = Blue + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 2] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Alpha = Alpha + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 3] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                        }
                    }
                }
                data[i] = Math.round(Red);
                data[i + 1] = Math.round(Green);
                data[i + 2] = Math.round(Blue);
                data[i + 3] = Math.round(Alpha);


            }
            var obj = new ImageData(data, imagedata.width, imagedata.height);
            return obj;
        }
    }

    function LowerIQ(imagedata) {
        var y = Math.round(imagedata.height / 10);
        var x = Math.round(imagedata.width / 10);
        var data = createIntArray(x * y * 4, 0);
        for (var m = 0; m < imagedata.height; m += 10) {
            for (var n = 0; n < imagedata.width; n += 10) {
                data[(n / 10 + Math.round(m / 10) * x) * 4] = imagedata.data[(m * imagedata.width + n) * 4];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 1] = imagedata.data[(m * imagedata.width + n) * 4 + 1];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 2] = imagedata.data[(m * imagedata.width + n) * 4 + 2];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 3] = imagedata.data[(m * imagedata.width + n) * 4 + 3];
            }
        }

        var obj = new ImageData(data, x, y);
        return obj;
    }

    function GusImage(image, width, height) {

    }


    function GetGusWeightArray() {
        var blurRadius = opts.blurRadius;
        var gusArray = createIntArray(blurRadius * 2 + 1, blurRadius * 2 + 1);
        var sigam = (blurRadius * 2 + 1) / 2;
        var count = 0;
        for (var y = -blurRadius; y < blurRadius + 1; y++) {
            for (var x = -blurRadius; x < blurRadius + 1; x++) {
                var weight = (1 / (2 * Math.PI * sigam * sigam)) * Math.pow(Math.E, (-(x * x + y * y) / (2 * sigam * sigam)));
                count = count + weight;
                gusArray[y + blurRadius][x + blurRadius] = weight;

            }
        }
        for (var k = 0; k < blurRadius * 2 + 1; k++) {
            for (var m = 0; m < blurRadius * 2 + 1; m++) {
                opts.gusArray[k][m] = gusArray[k][m] / count;
                opts.guslinearArray[k * (blurRadius * 2 + 1) + m] = gusArray[k][m] / count;
            }
        }
    }

    function createIntArray(x, y) {
        var arr ={};
        if (y) {
            arr = [];

            for (var j = 0; j < y; j++) {

                arr[j] = [];
                for (var i = 0; i < x; i++) {
                    arr[j][i] = 0.0;
                }

            }
        } else {
            arr = new Uint8ClampedArray(x);
        }
        return arr;
    }

    return function() {
        this.alert = alert;
        this.init = init;
    };
})();var Domhelper = function() {
    var data = {};

    var createKeywordPanel = function(data) {
        this.data = data;
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display', 'block');
        var ul = $('<ul></ul>');
        for (var i = 0; i < data.length && i < 10; i++) {
            var id = 'keyitem_' + i;
            var index = i;
            var li = $("<li id='" + 'suggestitem_' + i + "' class='suggestitem' index='" + i + "'><a><i class='default'>" + data[i].name + "</i><em>" + data[i].district + "</em></a></li>");

            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);

    };

    var CreateSearchResultPanel = function(data) {
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display', 'block');
        var ul = $('<ul></ul>');
        for (var i = 0; i < data.length && i < 10; i++) {


            var id = 'keyitem_' + i;
            var index = i;
            var li = $("<li id='" + 'keyitem_' + i + "' class='keyworditem' index='" + i + "'><a class='search_item'><i class='search'>" + data[i].name + "</i><em>" + data[i].address + "</em></a></li>");
            // li.on('click', function(e) {
            //     console.log(e);
            // });
            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);
    };

    this.CreateSearchResultPanel = CreateSearchResultPanel;
    this.createKeywordPanel = createKeywordPanel;
    this.data = data;
};//初始化派生类
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
});var chat = io();
chat.on('rep message',function(msg){
  $('#message').append(`<li>${msg}</li>`);
});
$('form').submit(function(){
  chat.emit('chat message',$('#m').val());
  $('#m').val('');
  return false;
});var Derivative = (function() {
    var opts = {
        canvas: '',
        blurRadius: 0,

    };

    function init(options) {
        //设置画布属性
        opts.canvas = options.canvas;
        opts.blurRadius = options.blurRadius;
        opts.gusArray = createIntArray(options.blurRadius * 2 + 1, options.blurRadius * 2 + 1);
        opts.guslinearArray = [];
        GetGusWeightArray();
        $(opts.canvas).attr('width', $(document).width());
        $(opts.canvas).attr('height', $(document).height());
        $(opts.canvas).css('display', 'none');
    }

    function alert() {
        //创建背景幕布
        html2canvas(document.body).then(canvas => {
            var ctx = $(opts.canvas).get(0).getContext('2d');
            console.log('开始渲染');
            var date1 = new Date(); //开始时间
            //var ImageData = GusImageData(LowerIQ(canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height())));
            var ImageData = GusImageData(canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height()));
            //var ImageData =canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height());
            var date2 = new Date(); //结束时间
            var date3 = date2.getTime() - date1.getTime(); //时间差的毫秒数
            console.log('结束渲染，用时' + date3);
            ctx.putImageData(ImageData, 0, 0, 0, 0, $(document).width(), $(document).height());
            $(opts.canvas).css('display', 'block');
        });

        //创建一个大盒子
        var box = document.createElement("div");　　 //创建一个关闭按钮
        var button = document.createElement("button");　　 //定义一个对象保存样式
        var boxName = {
            width: "500px",
            height: "180px",
            backgroundColor: "#f8f8f8",
            border: "1px solid #ccc",
            position: "absolute",
            top: "50%",
            left: "50%",
            margin: "-90px 0 0 -250px",
            zIndex: "999",
            textAlign: "center",
            lineHeight: "180px"
        };　　 //给元素添加元素
        for (var k in boxName) {
            box.style[k] = boxName[k];
        }　　 //把创建的元素添加到body中
        document.body.appendChild(box);　　 //把alert传入的内容添加到box中
        if (arguments[0]) {
            box.innerHTML = arguments[0];
        }
        button.innerHTML = "关闭";　　 //定义按钮样式
        var btnName = {
            border: "1px solid #ccc",
            backgroundColor: "#fff",
            width: "70px",
            height: "30px",
            textAlign: "center",
            lineHeight: "30px",
            outline: "none",
            position: "absolute",
            bottom: "10px",
            right: "20px",
        };
        for (var j in btnName) {
            button.style[j] = btnName[j];
        }　　 //把按钮添加到box中
        box.appendChild(button);　　 //给按钮添加单击事件
        button.addEventListener("click", function() {
            box.style.display = "none";
            $(opts.canvas).css('display', 'none');
        });
    }

    function GusImageData(imagedata) {
        var width = imagedata.width;
        var height = imagedata.height;
        var data = new createIntArray(imagedata.data.length, 0);
        var blurRadius = opts.blurRadius;
        if (width < blurRadius * 2 + 1 || height < blurRadius * 2 + 1) {
            console.log('高斯模糊的直接大于长或者宽，不支持');
        } else {
            for (var i = 0; i < imagedata.data.length; i += 4) {

                var Red = 0;
                var Green = 0;
                var Blue = 0;
                var Alpha = 0;
                for (var m = -blurRadius; m < blurRadius + 1; m++) {
                    for (var n = -blurRadius; n < blurRadius + 1; n++) {
                        if (Math.round(i / 4 / width) + m < 0 || Math.round(i / 4 / width) + m > height - 1 || ((i / 4) % width) + n < 0 || ((i / 4) % width) + n > width - 1) {
                            Red = Red + imagedata.data[i] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Green = Green + imagedata.data[i + 1] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Blue = Blue + imagedata.data[i + 2] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Alpha = Alpha + imagedata.data[i + 3] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                        } else {
                            Red = Red + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n)] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Green = Green + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 1] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Blue = Blue + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 2] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Alpha = Alpha + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 3] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                        }
                    }
                }
                data[i] = Math.round(Red);
                data[i + 1] = Math.round(Green);
                data[i + 2] = Math.round(Blue);
                data[i + 3] = Math.round(Alpha);


            }
            var obj = new ImageData(data, imagedata.width, imagedata.height);
            return obj;
        }
    }

    function LowerIQ(imagedata) {
        var y = Math.round(imagedata.height / 10);
        var x = Math.round(imagedata.width / 10);
        var data = createIntArray(x * y * 4, 0);
        for (var m = 0; m < imagedata.height; m += 10) {
            for (var n = 0; n < imagedata.width; n += 10) {
                data[(n / 10 + Math.round(m / 10) * x) * 4] = imagedata.data[(m * imagedata.width + n) * 4];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 1] = imagedata.data[(m * imagedata.width + n) * 4 + 1];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 2] = imagedata.data[(m * imagedata.width + n) * 4 + 2];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 3] = imagedata.data[(m * imagedata.width + n) * 4 + 3];
            }
        }

        var obj = new ImageData(data, x, y);
        return obj;
    }

    function GusImage(image, width, height) {

    }


    function GetGusWeightArray() {
        var blurRadius = opts.blurRadius;
        var gusArray = createIntArray(blurRadius * 2 + 1, blurRadius * 2 + 1);
        var sigam = (blurRadius * 2 + 1) / 2;
        var count = 0;
        for (var y = -blurRadius; y < blurRadius + 1; y++) {
            for (var x = -blurRadius; x < blurRadius + 1; x++) {
                var weight = (1 / (2 * Math.PI * sigam * sigam)) * Math.pow(Math.E, (-(x * x + y * y) / (2 * sigam * sigam)));
                count = count + weight;
                gusArray[y + blurRadius][x + blurRadius] = weight;

            }
        }
        for (var k = 0; k < blurRadius * 2 + 1; k++) {
            for (var m = 0; m < blurRadius * 2 + 1; m++) {
                opts.gusArray[k][m] = gusArray[k][m] / count;
                opts.guslinearArray[k * (blurRadius * 2 + 1) + m] = gusArray[k][m] / count;
            }
        }
    }

    function createIntArray(x, y) {
        var arr ={};
        if (y) {
            arr = [];

            for (var j = 0; j < y; j++) {

                arr[j] = [];
                for (var i = 0; i < x; i++) {
                    arr[j][i] = 0.0;
                }

            }
        } else {
            arr = new Uint8ClampedArray(x);
        }
        return arr;
    }

    return function() {
        this.alert = alert;
        this.init = init;
    };
})();var Domhelper = function() {
    var data = {};

    var createKeywordPanel = function(data) {
        this.data = data;
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display', 'block');
        var ul = $('<ul></ul>');
        for (var i = 0; i < data.length && i < 10; i++) {
            var id = 'keyitem_' + i;
            var index = i;
            var li = $("<li id='" + 'suggestitem_' + i + "' class='suggestitem' index='" + i + "'><a><i class='default'>" + data[i].name + "</i><em>" + data[i].district + "</em></a></li>");

            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);

    };

    var CreateSearchResultPanel = function(data) {
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display', 'block');
        var ul = $('<ul></ul>');
        for (var i = 0; i < data.length && i < 10; i++) {


            var id = 'keyitem_' + i;
            var index = i;
            var li = $("<li id='" + 'keyitem_' + i + "' class='keyworditem' index='" + i + "'><a class='search_item'><i class='search'>" + data[i].name + "</i><em>" + data[i].address + "</em></a></li>");
            // li.on('click', function(e) {
            //     console.log(e);
            // });
            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);
    };

    this.CreateSearchResultPanel = CreateSearchResultPanel;
    this.createKeywordPanel = createKeywordPanel;
    this.data = data;
};//初始化派生类
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
});var chat = io();
chat.on('rep message',function(msg){
  $('#message').append(`<li>${msg}</li>`);
});
$('form').submit(function(){
  chat.emit('chat message',$('#m').val());
  $('#m').val('');
  return false;
});var Derivative = (function() {
    var opts = {
        canvas: '',
        blurRadius: 0,

    };

    function init(options) {
        //设置画布属性
        opts.canvas = options.canvas;
        opts.blurRadius = options.blurRadius;
        opts.gusArray = createIntArray(options.blurRadius * 2 + 1, options.blurRadius * 2 + 1);
        opts.guslinearArray = [];
        GetGusWeightArray();
        $(opts.canvas).attr('width', $(document).width());
        $(opts.canvas).attr('height', $(document).height());
        $(opts.canvas).css('display', 'none');
    }

    function alert() {
        //创建背景幕布
        html2canvas(document.body).then(canvas => {
            var ctx = $(opts.canvas).get(0).getContext('2d');
            console.log('开始渲染');
            var date1 = new Date(); //开始时间
            //var ImageData = GusImageData(LowerIQ(canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height())));
            var ImageData = GusImageData(canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height()));
            //var ImageData =canvas.getContext('2d').getImageData(0, 0, $(document).width(), $(document).height());
            var date2 = new Date(); //结束时间
            var date3 = date2.getTime() - date1.getTime(); //时间差的毫秒数
            console.log('结束渲染，用时' + date3);
            ctx.putImageData(ImageData, 0, 0, 0, 0, $(document).width(), $(document).height());
            $(opts.canvas).css('display', 'block');
        });

        //创建一个大盒子
        var box = document.createElement("div");　　 //创建一个关闭按钮
        var button = document.createElement("button");　　 //定义一个对象保存样式
        var boxName = {
            width: "500px",
            height: "180px",
            backgroundColor: "#f8f8f8",
            border: "1px solid #ccc",
            position: "absolute",
            top: "50%",
            left: "50%",
            margin: "-90px 0 0 -250px",
            zIndex: "999",
            textAlign: "center",
            lineHeight: "180px"
        };　　 //给元素添加元素
        for (var k in boxName) {
            box.style[k] = boxName[k];
        }　　 //把创建的元素添加到body中
        document.body.appendChild(box);　　 //把alert传入的内容添加到box中
        if (arguments[0]) {
            box.innerHTML = arguments[0];
        }
        button.innerHTML = "关闭";　　 //定义按钮样式
        var btnName = {
            border: "1px solid #ccc",
            backgroundColor: "#fff",
            width: "70px",
            height: "30px",
            textAlign: "center",
            lineHeight: "30px",
            outline: "none",
            position: "absolute",
            bottom: "10px",
            right: "20px",
        };
        for (var j in btnName) {
            button.style[j] = btnName[j];
        }　　 //把按钮添加到box中
        box.appendChild(button);　　 //给按钮添加单击事件
        button.addEventListener("click", function() {
            box.style.display = "none";
            $(opts.canvas).css('display', 'none');
        });
    }

    function GusImageData(imagedata) {
        var width = imagedata.width;
        var height = imagedata.height;
        var data = new createIntArray(imagedata.data.length, 0);
        var blurRadius = opts.blurRadius;
        if (width < blurRadius * 2 + 1 || height < blurRadius * 2 + 1) {
            console.log('高斯模糊的直接大于长或者宽，不支持');
        } else {
            for (var i = 0; i < imagedata.data.length; i += 4) {

                var Red = 0;
                var Green = 0;
                var Blue = 0;
                var Alpha = 0;
                for (var m = -blurRadius; m < blurRadius + 1; m++) {
                    for (var n = -blurRadius; n < blurRadius + 1; n++) {
                        if (Math.round(i / 4 / width) + m < 0 || Math.round(i / 4 / width) + m > height - 1 || ((i / 4) % width) + n < 0 || ((i / 4) % width) + n > width - 1) {
                            Red = Red + imagedata.data[i] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Green = Green + imagedata.data[i + 1] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Blue = Blue + imagedata.data[i + 2] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Alpha = Alpha + imagedata.data[i + 3] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                        } else {
                            Red = Red + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n)] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Green = Green + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 1] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Blue = Blue + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 2] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                            Alpha = Alpha + imagedata.data[4 * ((Math.round(i / 4 / width) + m) * width + ((i / 4) % width) + n) + 3] * opts.guslinearArray[(m + blurRadius) * (blurRadius * 2 + 1) + n + blurRadius];
                        }
                    }
                }
                data[i] = Math.round(Red);
                data[i + 1] = Math.round(Green);
                data[i + 2] = Math.round(Blue);
                data[i + 3] = Math.round(Alpha);


            }
            var obj = new ImageData(data, imagedata.width, imagedata.height);
            return obj;
        }
    }

    function LowerIQ(imagedata) {
        var y = Math.round(imagedata.height / 10);
        var x = Math.round(imagedata.width / 10);
        var data = createIntArray(x * y * 4, 0);
        for (var m = 0; m < imagedata.height; m += 10) {
            for (var n = 0; n < imagedata.width; n += 10) {
                data[(n / 10 + Math.round(m / 10) * x) * 4] = imagedata.data[(m * imagedata.width + n) * 4];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 1] = imagedata.data[(m * imagedata.width + n) * 4 + 1];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 2] = imagedata.data[(m * imagedata.width + n) * 4 + 2];
                data[(n / 10 + Math.round(m / 10) * x) * 4 + 3] = imagedata.data[(m * imagedata.width + n) * 4 + 3];
            }
        }

        var obj = new ImageData(data, x, y);
        return obj;
    }

    function GusImage(image, width, height) {

    }


    function GetGusWeightArray() {
        var blurRadius = opts.blurRadius;
        var gusArray = createIntArray(blurRadius * 2 + 1, blurRadius * 2 + 1);
        var sigam = (blurRadius * 2 + 1) / 2;
        var count = 0;
        for (var y = -blurRadius; y < blurRadius + 1; y++) {
            for (var x = -blurRadius; x < blurRadius + 1; x++) {
                var weight = (1 / (2 * Math.PI * sigam * sigam)) * Math.pow(Math.E, (-(x * x + y * y) / (2 * sigam * sigam)));
                count = count + weight;
                gusArray[y + blurRadius][x + blurRadius] = weight;

            }
        }
        for (var k = 0; k < blurRadius * 2 + 1; k++) {
            for (var m = 0; m < blurRadius * 2 + 1; m++) {
                opts.gusArray[k][m] = gusArray[k][m] / count;
                opts.guslinearArray[k * (blurRadius * 2 + 1) + m] = gusArray[k][m] / count;
            }
        }
    }

    function createIntArray(x, y) {
        var arr ={};
        if (y) {
            arr = [];

            for (var j = 0; j < y; j++) {

                arr[j] = [];
                for (var i = 0; i < x; i++) {
                    arr[j][i] = 0.0;
                }

            }
        } else {
            arr = new Uint8ClampedArray(x);
        }
        return arr;
    }

    return function() {
        this.alert = alert;
        this.init = init;
    };
})();var Domhelper = function() {
    var data = {};

    var createKeywordPanel = function(data) {
        this.data = data;
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display', 'block');
        var ul = $('<ul></ul>');
        for (var i = 0; i < data.length && i < 10; i++) {
            var id = 'keyitem_' + i;
            var index = i;
            var li = $("<li id='" + 'suggestitem_' + i + "' class='suggestitem' index='" + i + "'><a><i class='default'>" + data[i].name + "</i><em>" + data[i].district + "</em></a></li>");

            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);

    };

    var CreateSearchResultPanel = function(data) {
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display', 'block');
        var ul = $('<ul></ul>');
        for (var i = 0; i < data.length && i < 10; i++) {


            var id = 'keyitem_' + i;
            var index = i;
            var li = $("<li id='" + 'keyitem_' + i + "' class='keyworditem' index='" + i + "'><a class='search_item'><i class='search'>" + data[i].name + "</i><em>" + data[i].address + "</em></a></li>");
            // li.on('click', function(e) {
            //     console.log(e);
            // });
            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);
    };

    this.CreateSearchResultPanel = CreateSearchResultPanel;
    this.createKeywordPanel = createKeywordPanel;
    this.data = data;
};//初始化派生类
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