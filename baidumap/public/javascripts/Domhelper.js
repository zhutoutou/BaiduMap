var Domhelper = function() {
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
            li.on('click', function(e) {
                console.log(e);
            })
            ul.append(li);
        }
        $('#searchrestult_panel').append(ul);
    };

    this.CreateSearchResultPanel = CreateSearchResultPanel;
    this.createKeywordPanel = createKeywordPanel;
    this.data = data;
}