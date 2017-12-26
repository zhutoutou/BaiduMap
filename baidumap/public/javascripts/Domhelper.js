var Domhelper = function() {
    var data = {};

    var createKeywordPanel = function(data) {
        this.data =data;
        $('#searchrestult_panel').empty();
        $('#searchrestult_panel').css('display','flex');
        var ul =$('<ul></ul>');
        for (var i = 0; i < data.length && i < 5; i++) {
            var id ='keyitem_' + i;
            var index = i;
            var li = $("<li id='"+ 'keyitem_' + i +"' class='keyworditem' index='"+ i +"'><a><i class='default'>"+ data[i].name +"</i><em>"+ data[i].district+"</em></a></li>");
            li.on('click',function(e){
              console.log(e);
            })
            ul.append(li);
            
            //div.appendto();
        }
        $('#searchrestult_panel').append(ul);
    }
    this.createKeywordPanel = createKeywordPanel;
}