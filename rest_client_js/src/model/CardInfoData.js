/**
 * MDES for Merchants
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously.  
 *
 * OpenAPI spec version: 1.2.7
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.0-SNAPSHOT
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/BillingAddress'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./BillingAddress'));
  } else {
    // Browser globals (root is window)
    if (!root.MdesForMerchants) {
      root.MdesForMerchants = {};
    }
    root.MdesForMerchants.CardInfoData = factory(root.MdesForMerchants.ApiClient, root.MdesForMerchants.BillingAddress);
  }
}(this, function(ApiClient, BillingAddress) {
  'use strict';




  /**
   * The CardInfoData model module.
   * @module model/CardInfoData
   * @version 1.2.7
   */

  /**
   * Constructs a new <code>CardInfoData</code>.
   * @alias module:model/CardInfoData
   * @class
   */
  var exports = function() {
    var _this = this;








  };

  /**
   * Constructs a <code>CardInfoData</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/CardInfoData} obj Optional instance to populate.
   * @return {module:model/CardInfoData} The populated <code>CardInfoData</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('accountNumber')) {
        obj['accountNumber'] = ApiClient.convertToType(data['accountNumber'], 'String');
      }
      if (data.hasOwnProperty('expiryMonth')) {
        obj['expiryMonth'] = ApiClient.convertToType(data['expiryMonth'], 'String');
      }
      if (data.hasOwnProperty('expiryYear')) {
        obj['expiryYear'] = ApiClient.convertToType(data['expiryYear'], 'String');
      }
      if (data.hasOwnProperty('source')) {
        obj['source'] = ApiClient.convertToType(data['source'], 'String');
      }
      if (data.hasOwnProperty('cardholderName')) {
        obj['cardholderName'] = ApiClient.convertToType(data['cardholderName'], 'String');
      }
      if (data.hasOwnProperty('securityCode')) {
        obj['securityCode'] = ApiClient.convertToType(data['securityCode'], 'String');
      }
      if (data.hasOwnProperty('billingAddress')) {
        obj['billingAddress'] = BillingAddress.constructFromObject(data['billingAddress']);
      }
    }
    return obj;
  }

  /**
   * __(Required as minimum for Tokenization)__ The account number to be encrypted for tokenization. Only supplied if panUniqueReference or tokenUniqueReferenceForPanInfo is not present.   __Min Length:9__<br> __Max Length:19__ 
   * @member {String} accountNumber
   */
  exports.prototype['accountNumber'] = undefined;
  /**
   * __(Required as minimum for Tokenization)__ The expiry month for the account. Only supplied if panUniqueReference or tokenUniqueReferenceForPanInfo is not present. Two numeric digits must be supplied. __Format: MM__<br> __Exact Length:2__ 
   * @member {String} expiryMonth
   */
  exports.prototype['expiryMonth'] = undefined;
  /**
   * __(Required as minimum for Tokenization)__  The expiry year for the account. Only supplied if panUniqueReference or tokenUniqueReferenceForPanInfo is not present. <br> __Format: YY__<br> __Exact Length:2__ 
   * @member {String} expiryYear
   */
  exports.prototype['expiryYear'] = undefined;
  /**
   * (__Required as minimum for Tokenization__)  The source of the account.   __Max Length:32__ 
   * @member {String} source
   */
  exports.prototype['source'] = undefined;
  /**
   * __(OPTIONAL)__ The name of the cardholder<br> __Max Length:27__ 
   * @member {String} cardholderName
   */
  exports.prototype['cardholderName'] = undefined;
  /**
   * __(OPTIONAL)__ The security code for the account can optionally be provided for Tokenization. If provided, the validity will be checked.  __Max Length:3__ 
   * @member {String} securityCode
   */
  exports.prototype['securityCode'] = undefined;
  /**
   * @member {module:model/BillingAddress} billingAddress
   */
  exports.prototype['billingAddress'] = undefined;



  return exports;
}));

