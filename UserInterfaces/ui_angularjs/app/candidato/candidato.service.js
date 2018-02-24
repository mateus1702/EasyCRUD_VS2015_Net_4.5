'use strict';

angular.
  module('candidato').
  factory('Candidato', ['$resource',
    function($resource) {
      return $resource('http://localhost:55189/api/candidato/:Id', { Id: '@Id' }, {
        update: {
          method: 'PUT'
        },
        delete: {
          method: 'DELETE'
        }
      });
    }
  ]);
