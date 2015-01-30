module.exports = function(grunt) {

    var cssFiles = [
        "bower_components/bootstrap/dist/css/bootstrap.css",
        "bower_components/bootstrap/dist/css/bootstrap-theme.css"
    ];

    require("matchdep").filterDev("grunt-*").forEach(grunt.loadNpmTasks);

    grunt.initConfig({

        pkg: grunt.file.readJSON('package.json'),

        jsbeautifier: {
            files: ["app/**"],
            options: {}
        },

        concat: {
            options: {
              separator: ';',
            },
            dist: {
              src: ['bower_components/bootstrap/dist/bootstrap.js'],
              dest: 'dist/rmessagebus.min.js',
            },
        },

        cssmin: {
            options: {
                banner: '/*! <%= pkg.name %> <%= grunt.template.today("yyyy-mm-dd") %> */\n'
            },
            combine: {
                files: {
                    'dist/rmessagebus.min.css': cssFiles
                }
            }
        },

        jshint: {
            files: ['app/**/*.js', '!app/lib/**/*.js']
        },        

        watch: {
            files: ["app/**", "tests/**"],
            tasks: ['default']
        }
        
    });

    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.registerTask('dist', ['cssmin', 'concat']);
};
