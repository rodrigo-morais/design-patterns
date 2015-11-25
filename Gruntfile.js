module.exports = function (grunt) {
    grunt.initConfig({
        jshint: {
            options: {
                strict: false,
                node: true,
                esnext: true,
                scripturl:true,
                globals: {
                    angular: true,
                    window: true
                }
            },
            all: ['app/**/*.js', 'tests/unit/**/*.js']
        },
        'babel': {
            dist: {
                files: [{
                    expand: true,
                    cwd: 'app',
                    src: ['**/*.js'],
                    dest: 'dist/app',
                    ext: '.js'
                }]
            }
        },
        clean: ["dist/"],
        copy: {
            main: {
                cwd: './',
                src: 'index.html',
                dest: 'dist/',
                expand: true,
                flatten: true,
                filter: 'isFile'
            },
            css: {
                cwd: './',
                src: 'assets/**',
                dest: 'dist/',
                expand: true
            },
            vendor: {
                cwd: './',
                src: 'vendor/**',
                dest: 'dist/',
                expand: true,
                filter: 'isFile'
            },
            app_css: {
                cwd: './',
                src: 'app/**/css/*.css',
                dest: 'dist/',
                expand: true
            },
            app_html: {
                cwd: './',
                src: 'app/**/*.html',
                dest: 'dist/',
                expand: true
            },
            app_generators_js: {
                cwd: './',
                src: 'app/functional/generators/generators.js',
                dest: 'dist/app/functional/generators/generators.js'
            },
            app_proxy_js: {
                cwd: './',
                src: 'app/objects/proxy/proxy.js',
                dest: 'dist/app/objects/proxy/proxy.js'
            }
        },
        watch: {
            files: [
                'app/**/*.*',
                'assets/**/*.css',
                'tests/unit/**/*.js',
                'index.html'
            ],
            tasks: [
                'jshint', 'clean', 'babel', 'copy'
            ]
        }
    });

    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-jshint');
    grunt.loadNpmTasks('grunt-babel');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-clean');
    grunt.registerTask('default', ['jshint', 'clean', 'babel', 'copy']);
};