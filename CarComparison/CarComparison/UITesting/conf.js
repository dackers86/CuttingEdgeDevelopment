// An example configuration file.
exports.config = {
  seleniumAddress: 'http://127.0.0.1:4444/wd/hub',

  // Capabilities to be passed to the webdriver instance.
  capabilities: {
    'browserName': 'chrome'
  },

  baseUrl:' http://www.carcomparison.com.local',

  // Spec patterns are relative to the current working directly when
  // protractor is called.
  specs: ['e2e/*.spec.js'],

  // Options to be passed to Jasmine-node.
  jasmineNodeOpts: {
    showColors: true,
    defaultTimeoutInterval: 30000
  }
};
