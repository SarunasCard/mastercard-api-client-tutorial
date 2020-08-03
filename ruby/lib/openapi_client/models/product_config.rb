=begin
#MDES for Merchants

#The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously. <br> __Authentication__ Mastercard uses OAuth 1.0a with body hash extension for authenticating the API clients. This requires every request that you send to  Mastercard to be signed with an RSA private key. A private-public RSA key pair must be generated consisting of: <br> 1 . A private key for the OAuth signature for API requests. It is recommended to keep the private key in a password-protected or hardware keystore. <br> 2. A public key is shared with Mastercard during the project setup process through either a certificate signing request (CSR) or the API Key Generator. Mastercard will use the public key to verify the OAuth signature that is provided on every API call.<br>  An OAUTH1.0a signer library is available on [GitHub](https://github.com/Mastercard/oauth1-signer-java) <br>  __Encryption__<br>  All communications between Issuer web service and the Mastercard gateway is encrypted using TLS. <br> __Additional Encryption of Sensitive Data__ In addition to the OAuth authentication, when using MDES Digital Enablement Service, any PCI sensitive and all account holder Personally Identifiable Information (PII) data must be encrypted. This requirement applies to the API fields containing encryptedData. Sensitive data is encrypted using a symmetric session (one-time-use) key. The symmetric session key is then wrapped with an RSA Public Key supplied by Mastercard during API setup phase (the Customer Encryption Key). <br>  Java Client Encryption Library available on [GitHub](https://github.com/Mastercard/client-encryption-java) 

The version of the OpenAPI document: 1.2.10

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'date'

module OpenapiClient
  class ProductConfig
    # The MasterCard or Maestro brand logo associated with this card. Provided as an Asset ID – use the Get Asset API to retrieve the actual asset. Always returned in Product Configuration object <br>    __Max Length: 64__<br> __Required: Yes__ 
    attr_accessor :brand_logo_asset_id

    # The logo of the issuing bank. Provided as an Asset ID – use the Get Asset API to retrieve the actual asset. Always returned in Product Configuration object <br>     __Max Length:64__<br> __Required: Yes__ 
    attr_accessor :issuer_logo_asset_id

    # Whether the product is co-branded. Must be either true (this is a co-branded product) or false (this is not a co-branded product). Always returned in Product Configuration object <br>    __Max Length:5__<br> __Required: Yes__ 
    attr_accessor :is_co_branded

    # Textual name of the co-brand partner. Required if CoBranded is true, not present otherwise.  <br>   __Max Length:128__<br> __Required: Conditional – required if isCoBranded = \"true\". Not present otherwise__ 
    attr_accessor :co_brand_name

    # The co-brand logo (if any) for this product. Provided as an Asset ID – use the Get Asset API to retrieve the actual asset. <br>   __Max Length:64__<br> __Required: No__ 
    attr_accessor :co_brand_logo_asset_id

    # The card image used to represent the digital card in the wallet. This ‘combined’ option contains the MasterCard, bank and any co- brand logos.  Provided as an Asset ID – use the Get Asset API to retrieve the actual asset.     __Max Length:64__<br> __Required: Conditional – either CardBackgroundCombined or CardBackground will be provided__ 
    attr_accessor :card_background_combined_asset_id

    # The card image used to represent the digital card in the wallet. This ‘non-combined’ option does not contain the MasterCard, bank, or co-brand logos. Provided as an Asset ID – use the Get Asset API to retrieve the actual asset. <br>     __Max Length:64__<br> __Required: Conditional – either CardBackgroundCombined or CardBackground will be provided__ 
    attr_accessor :card_background_asset_id

    # The icon representing the primary brand(s) associated with this product. Provided as an Asset ID – use the Get Asset API to retrieve the actual asset. Always returned in Product Configuration object<br>    __Max Length:64__<br> __Required: Yes__ 
    attr_accessor :icon_asset_id

    # Foreground color, used to overlay text on top of the card image. Always returned in Product Configuration object<br>    __Max Length:6__ Hexadecimal RGB color format (case-insensitive).<br> __Required: Yes__ 
    attr_accessor :foreground_color

    # Name of the issuing bank. Always returned in Product Configuration object <br>    __Max Length:64__<br> __Required: Yes__ 
    attr_accessor :issuer_name

    # A short description for this product. Always returned in Product Configuration object  <br>   __Max Length:128__<br> __Required: Yes__ 
    attr_accessor :short_description

    # A long description for this product.  <br>   __Max Length:256__<br> __Required: No__ 
    attr_accessor :long_description

    # Customer service website of the issuing bank. <br>    __Max Length:128__<br> __Required: No__ 
    attr_accessor :customer_service_url

    # Customer service email address of the issuing bank. <br>    __Max Length:64__<br> __Required: No__ 
    attr_accessor :customer_service_email

    # Customer service phone number of the issuing bank. <br>    __Max Length:64__<br> __Required: No__ 
    attr_accessor :customer_service_phone_number

    # Contains one or more mobile app details that may be used to deep link from the Mobile Payment App to the issuer mobile app. <br>    __Max Length:64__<br> __Required: No__ 
    attr_accessor :issuer_mobile_app

    # Logon URL for the issuing bank’s online banking website.<br>     __Max Length:128__ 
    attr_accessor :online_banking_login_url

    # URL linking to the issuing bank’s terms and conditions for this product.<br>     __Max Length:128__<br> __Required: No__ 
    attr_accessor :terms_and_conditions_url

    # URL linking to the issuing bank’s privacy policy for this product.<br>     __Max Length:128__<br> __Required: No__ 
    attr_accessor :privacy_policy_url

    # Freeform identifier for this product configuration as assigned by the issuer.<br>     __Max Length:128__<br> __Required: No__ 
    attr_accessor :issuer_product_config_code

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'brand_logo_asset_id' => :'brandLogoAssetId',
        :'issuer_logo_asset_id' => :'issuerLogoAssetId',
        :'is_co_branded' => :'isCoBranded',
        :'co_brand_name' => :'coBrandName',
        :'co_brand_logo_asset_id' => :'coBrandLogoAssetId',
        :'card_background_combined_asset_id' => :'cardBackgroundCombinedAssetId',
        :'card_background_asset_id' => :'cardBackgroundAssetId',
        :'icon_asset_id' => :'iconAssetId',
        :'foreground_color' => :'foregroundColor',
        :'issuer_name' => :'issuerName',
        :'short_description' => :'shortDescription',
        :'long_description' => :'longDescription',
        :'customer_service_url' => :'customerServiceUrl',
        :'customer_service_email' => :'customerServiceEmail',
        :'customer_service_phone_number' => :'customerServicePhoneNumber',
        :'issuer_mobile_app' => :'issuerMobileApp',
        :'online_banking_login_url' => :'onlineBankingLoginUrl',
        :'terms_and_conditions_url' => :'termsAndConditionsUrl',
        :'privacy_policy_url' => :'privacyPolicyUrl',
        :'issuer_product_config_code' => :'issuerProductConfigCode'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'brand_logo_asset_id' => :'String',
        :'issuer_logo_asset_id' => :'String',
        :'is_co_branded' => :'String',
        :'co_brand_name' => :'String',
        :'co_brand_logo_asset_id' => :'String',
        :'card_background_combined_asset_id' => :'String',
        :'card_background_asset_id' => :'String',
        :'icon_asset_id' => :'String',
        :'foreground_color' => :'String',
        :'issuer_name' => :'String',
        :'short_description' => :'String',
        :'long_description' => :'String',
        :'customer_service_url' => :'String',
        :'customer_service_email' => :'String',
        :'customer_service_phone_number' => :'String',
        :'issuer_mobile_app' => :'Object',
        :'online_banking_login_url' => :'String',
        :'terms_and_conditions_url' => :'String',
        :'privacy_policy_url' => :'String',
        :'issuer_product_config_code' => :'String'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OpenapiClient::ProductConfig` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OpenapiClient::ProductConfig`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'brand_logo_asset_id')
        self.brand_logo_asset_id = attributes[:'brand_logo_asset_id']
      end

      if attributes.key?(:'issuer_logo_asset_id')
        self.issuer_logo_asset_id = attributes[:'issuer_logo_asset_id']
      end

      if attributes.key?(:'is_co_branded')
        self.is_co_branded = attributes[:'is_co_branded']
      end

      if attributes.key?(:'co_brand_name')
        self.co_brand_name = attributes[:'co_brand_name']
      end

      if attributes.key?(:'co_brand_logo_asset_id')
        self.co_brand_logo_asset_id = attributes[:'co_brand_logo_asset_id']
      end

      if attributes.key?(:'card_background_combined_asset_id')
        self.card_background_combined_asset_id = attributes[:'card_background_combined_asset_id']
      end

      if attributes.key?(:'card_background_asset_id')
        self.card_background_asset_id = attributes[:'card_background_asset_id']
      end

      if attributes.key?(:'icon_asset_id')
        self.icon_asset_id = attributes[:'icon_asset_id']
      end

      if attributes.key?(:'foreground_color')
        self.foreground_color = attributes[:'foreground_color']
      end

      if attributes.key?(:'issuer_name')
        self.issuer_name = attributes[:'issuer_name']
      end

      if attributes.key?(:'short_description')
        self.short_description = attributes[:'short_description']
      end

      if attributes.key?(:'long_description')
        self.long_description = attributes[:'long_description']
      end

      if attributes.key?(:'customer_service_url')
        self.customer_service_url = attributes[:'customer_service_url']
      end

      if attributes.key?(:'customer_service_email')
        self.customer_service_email = attributes[:'customer_service_email']
      end

      if attributes.key?(:'customer_service_phone_number')
        self.customer_service_phone_number = attributes[:'customer_service_phone_number']
      end

      if attributes.key?(:'issuer_mobile_app')
        self.issuer_mobile_app = attributes[:'issuer_mobile_app']
      end

      if attributes.key?(:'online_banking_login_url')
        self.online_banking_login_url = attributes[:'online_banking_login_url']
      end

      if attributes.key?(:'terms_and_conditions_url')
        self.terms_and_conditions_url = attributes[:'terms_and_conditions_url']
      end

      if attributes.key?(:'privacy_policy_url')
        self.privacy_policy_url = attributes[:'privacy_policy_url']
      end

      if attributes.key?(:'issuer_product_config_code')
        self.issuer_product_config_code = attributes[:'issuer_product_config_code']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          brand_logo_asset_id == o.brand_logo_asset_id &&
          issuer_logo_asset_id == o.issuer_logo_asset_id &&
          is_co_branded == o.is_co_branded &&
          co_brand_name == o.co_brand_name &&
          co_brand_logo_asset_id == o.co_brand_logo_asset_id &&
          card_background_combined_asset_id == o.card_background_combined_asset_id &&
          card_background_asset_id == o.card_background_asset_id &&
          icon_asset_id == o.icon_asset_id &&
          foreground_color == o.foreground_color &&
          issuer_name == o.issuer_name &&
          short_description == o.short_description &&
          long_description == o.long_description &&
          customer_service_url == o.customer_service_url &&
          customer_service_email == o.customer_service_email &&
          customer_service_phone_number == o.customer_service_phone_number &&
          issuer_mobile_app == o.issuer_mobile_app &&
          online_banking_login_url == o.online_banking_login_url &&
          terms_and_conditions_url == o.terms_and_conditions_url &&
          privacy_policy_url == o.privacy_policy_url &&
          issuer_product_config_code == o.issuer_product_config_code
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [brand_logo_asset_id, issuer_logo_asset_id, is_co_branded, co_brand_name, co_brand_logo_asset_id, card_background_combined_asset_id, card_background_asset_id, icon_asset_id, foreground_color, issuer_name, short_description, long_description, customer_service_url, customer_service_email, customer_service_phone_number, issuer_mobile_app, online_banking_login_url, terms_and_conditions_url, privacy_policy_url, issuer_product_config_code].hash
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def self.build_from_hash(attributes)
      new.build_from_hash(attributes)
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def build_from_hash(attributes)
      return nil unless attributes.is_a?(Hash)
      self.class.openapi_types.each_pair do |key, type|
        if type =~ /\AArray<(.*)>/i
          # check to ensure the input is an array given that the attribute
          # is documented as an array but the input is not
          if attributes[self.class.attribute_map[key]].is_a?(Array)
            self.send("#{key}=", attributes[self.class.attribute_map[key]].map { |v| _deserialize($1, v) })
          end
        elsif !attributes[self.class.attribute_map[key]].nil?
          self.send("#{key}=", _deserialize(type, attributes[self.class.attribute_map[key]]))
        end # or else data not found in attributes(hash), not an issue as the data can be optional
      end

      self
    end

    # Deserializes the data based on type
    # @param string type Data type
    # @param string value Value to be deserialized
    # @return [Object] Deserialized data
    def _deserialize(type, value)
      case type.to_sym
      when :DateTime
        DateTime.parse(value)
      when :Date
        Date.parse(value)
      when :String
        value.to_s
      when :Integer
        value.to_i
      when :Float
        value.to_f
      when :Boolean
        if value.to_s =~ /\A(true|t|yes|y|1)\z/i
          true
        else
          false
        end
      when :Object
        # generic object (usually a Hash), return directly
        value
      when /\AArray<(?<inner_type>.+)>\z/
        inner_type = Regexp.last_match[:inner_type]
        value.map { |v| _deserialize(inner_type, v) }
      when /\AHash<(?<k_type>.+?), (?<v_type>.+)>\z/
        k_type = Regexp.last_match[:k_type]
        v_type = Regexp.last_match[:v_type]
        {}.tap do |hash|
          value.each do |k, v|
            hash[_deserialize(k_type, k)] = _deserialize(v_type, v)
          end
        end
      else # model
        OpenapiClient.const_get(type).build_from_hash(value)
      end
    end

    # Returns the string representation of the object
    # @return [String] String presentation of the object
    def to_s
      to_hash.to_s
    end

    # to_body is an alias to to_hash (backward compatibility)
    # @return [Hash] Returns the object in the form of hash
    def to_body
      to_hash
    end

    # Returns the object in the form of hash
    # @return [Hash] Returns the object in the form of hash
    def to_hash
      hash = {}
      self.class.attribute_map.each_pair do |attr, param|
        value = self.send(attr)
        if value.nil?
          is_nullable = self.class.openapi_nullable.include?(attr)
          next if !is_nullable || (is_nullable && !instance_variable_defined?(:"@#{attr}"))
        end
        
        hash[param] = _to_hash(value)
      end
      hash
    end

    # Outputs non-array value in the form of hash
    # For object, use to_hash. Otherwise, just return the value
    # @param [Object] value Any valid value
    # @return [Hash] Returns the value in the form of hash
    def _to_hash(value)
      if value.is_a?(Array)
        value.compact.map { |v| _to_hash(v) }
      elsif value.is_a?(Hash)
        {}.tap do |hash|
          value.each { |k, v| hash[k] = _to_hash(v) }
        end
      elsif value.respond_to? :to_hash
        value.to_hash
      else
        value
      end
    end
  end
end
