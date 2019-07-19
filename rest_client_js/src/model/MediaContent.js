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
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.MdesForMerchants) {
      root.MdesForMerchants = {};
    }
    root.MdesForMerchants.MediaContent = factory(root.MdesForMerchants.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';




  /**
   * The MediaContent model module.
   * @module model/MediaContent
   * @version 1.2.7
   */

  /**
   * Constructs a new <code>MediaContent</code>.
   * @alias module:model/MediaContent
   * @class
   * @param type {String} What type of media this is. Specified as a MIME type, which will be one of the following supported types   * applicatoin/pdf (for images must be a vector PDF image) * image/png (includes alpha channel) * text/plain  * text/html  __Max Length:32__  
   * @param data {String} The data for this item of media. Base64-encoded data, given in the format as specified in �type�. 
   */
  var exports = function(type, data) {
    var _this = this;

    _this['type'] = type;
    _this['data'] = data;


  };

  /**
   * Constructs a <code>MediaContent</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/MediaContent} obj Optional instance to populate.
   * @return {module:model/MediaContent} The populated <code>MediaContent</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
      if (data.hasOwnProperty('data')) {
        obj['data'] = ApiClient.convertToType(data['data'], 'String');
      }
      if (data.hasOwnProperty('height')) {
        obj['height'] = ApiClient.convertToType(data['height'], 'String');
      }
      if (data.hasOwnProperty('width')) {
        obj['width'] = ApiClient.convertToType(data['width'], 'String');
      }
    }
    return obj;
  }

  /**
   * What type of media this is. Specified as a MIME type, which will be one of the following supported types   * applicatoin/pdf (for images must be a vector PDF image) * image/png (includes alpha channel) * text/plain  * text/html  __Max Length:32__  
   * @member {String} type
   */
  exports.prototype['type'] = undefined;
  /**
   * The data for this item of media. Base64-encoded data, given in the format as specified in �type�. 
   * @member {String} data
   */
  exports.prototype['data'] = undefined;
  /**
   * For image assets, the height of this image. Specified in pixels.     __Max Length:6__  
   * @member {String} height
   */
  exports.prototype['height'] = undefined;
  /**
   * For image assets, the width of this image. Specified in pixels.        __Max Length:6__  
   * @member {String} width
   */
  exports.prototype['width'] = undefined;



  return exports;
}));

