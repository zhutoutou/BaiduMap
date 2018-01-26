module.exports = function(grunt) {
    // Project configuration
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        qunit:{
            files:['view/*.jade']
        },
        jshint:{
            // define the files to lint
            files:['gruntfile.js','public/javascripts/*.js'],
            // configure JSHint (documented at http://www.jshint.com/docs/)
            options: {
                // more options here if you want to override JSHint defaults
                esversion: 6,
                globals: {
                  jQuery: true,
                  console: true,
                  module: true
                }
            }
        },
        concat:{
            options:{
                //定义一个用处插入合并输出文件之间的字符
                separator:''
            },
            dist:{
                //将要合并的文件
                src:['public/javascripts/*.js'],
                //合并后的js文件的存放的位置
                dest:'public/javascripts/<%= pkg.name %>_es6.js'
            }
        },
        babel:{
            options:{
                sourceMap:false,
                presets:['env']
            },
            dist:{
                files:{
                    'public/javascripts/<%= pkg.name %>_es5.js':'<%= concat.dist.dest %>'
                }
            }
        },
        watch:{
            files:['<%= jshint.files %>'],
            task:['jshint','qunit']
        },

        uglify: {
            options: {
                mangle:true,
                banner: '/*! <%= pkg.name %> <%= grunt.template.today("yyyy-mm-dd") %> */\n'
            },
            dist:{
                files:{
                    'public/javascripts/<%= pkg.name %>.min.js':['public/javascripts/<%= pkg.name %>_es5.js']
                }
            }
        },
        sass:{
            options:{
                sourceMap:true
            },
            dist:{

            }
        }
    });
    
    // Load the plugin that provides the "uglify" task.
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-jshint');
    grunt.loadNpmTasks('grunt-contrib-qunit');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-babel');
    // Load the plugin that provides the "sass" task.
    grunt.loadNpmTasks('grunt-contrib-sass');
    //默认被默认执行的任务列表
    grunt.registerTask('default', ['jshint', 'qunit', 'concat','babel', 'uglify']);

    grunt.registerTask('test', ['jshint','qunit']);
};