var chat = io();
chat.on('rep message',function(msg){
  $('#message').append(`<li>${msg}</li>`);
});
$('form').submit(function(){
  chat.emit('chat message',$('#m').val());
  $('#m').val('');
  return false;
});