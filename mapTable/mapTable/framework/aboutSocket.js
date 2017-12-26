// 根据socketid删除socket列表中对应的socket对象
var removeSocketObj = function(socketObjs, id) {
    socketObjs.splice(findIndexOfObjs(socketObjs, id), 1)
};
// 根据socketId获取socket列象
var findIndexOfObjs = function(socketObjs, id, key = 'id') {
    for (var i in socketObjs) {
        if (socketObjs[i][key] == id) {
            return i
        }
    }
    return -1
};
// 根据socketId获取socket列表中对象
var findSocketObjById = function(socketObjs, id) {
    return socketObjs[findIndexOfObjs(socketObjs, id)]
};

var aboutSocket = {
    removeSocketObj: removeSocketObj,
    findIndexOfObjs: findIndexOfObjs,
    findSocketObjById: findSocketObjById
}

module.exports = aboutSocket
