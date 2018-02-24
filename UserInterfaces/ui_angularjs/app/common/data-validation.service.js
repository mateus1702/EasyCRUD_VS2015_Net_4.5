'use strict';

angular.
  module('common').
  factory('DataValidation',function() {
    return {
      isNumber: function (inputString){
        var patt = new RegExp(/[0-9]+/);
        return patt.test(inputString);
      },
      isDecimal: function (inputString) {
        var patt = new RegExp(/^\d+(\,\d{1,10})?$/);
        return patt.test(inputString);
      },
      isEmail: function (inputString){
        var patt = new RegExp(/^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/);
        return patt.test(inputString);
      },
      isCPFValid: function (inputString) {
        var Soma;
        var Resto;
        Soma = 0;
    	  if (inputString == "00000000000")
          return false;

      	for (var i=1; i<=9; i++)
          Soma = Soma + parseInt(inputString.substring(i-1, i)) * (11 - i);
      	Resto = (Soma * 10) % 11;

        if ((Resto == 10) || (Resto == 11))
          Resto = 0;
        if (Resto != parseInt(inputString.substring(9, 10)) )
          return false;

    	  Soma = 0;
        for (var i = 1; i <= 10; i++)
          Soma = Soma + parseInt(inputString.substring(i-1, i)) * (12 - i);
        Resto = (Soma * 10) % 11;

        if ((Resto == 10) || (Resto == 11))
          Resto = 0;
        if (Resto != parseInt(inputString.substring(10, 11) ) )
          return false;
        return true;
      }
    }
  });
