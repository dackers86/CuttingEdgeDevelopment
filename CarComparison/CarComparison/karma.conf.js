// Karma configuration
// Generated on Sat Mar 29 2014 23:49:37 GMT+0000 (GMT Standard Time)

module.exports = function(config) {
  config.set({

    // base path that will be used to resolve all patterns (eg. files, exclude)
    basePath: '',


    // frameworks to use
    // available frameworks: https://npmjs.org/browse/keyword/karma-adapter
    frameworks: ['jasmine'],
	
    // list of files / patterns to load in the browser
    files: [
	
	   /*** Required Libraries ***/
	   'Scripts/jquery-1.9.1.js',
	   'Scripts/angular.js',
	   
	   	/*** Mocks ***/
	   'Scripts/angular-mocks.js',
	   
	   /*** Templates ***/
	   'js/*.js',
	   
	   
	   /*** Apps Test ***/
	  'Scripts/Test/Unit/spec/*.js'
	  
    ],


    // list of files to exclude
    exclude: [
      '*.html'
    ],


    // preprocess matching files before serving them to the browser
    // available preprocessors: https://npmjs.org/browse/keyword/karma-preprocessor
    preprocessors: {
    
    },


    // test results reporter to use
    // possible values: 'dots', 'progress'
    // available reporters: https://npmjs.org/browse/keyword/karma-reporter
    reporters: ['progress'],


    // web server port
    port: 8000,


    // enable / disable colors in the output (reporters and logs)
    colors: true,


    // level of logging
    // possible values: config.LOG_DISABLE || config.LOG_ERROR || config.LOG_WARN || config.LOG_INFO || config.LOG_DEBUG
    logLevel: config.LOG_INFO,


    // enable / disable watching file and executing tests whenever any file changes
    autoWatch: true,


    // start these browsers
    // available browser launchers: https://npmjs.org/browse/keyword/karma-launcher
    browsers: ['Chrome'],


    // Continuous Integration mode
    // if true, Karma captures browsers, runs the tests and exits
    singleRun: false
  });
};
