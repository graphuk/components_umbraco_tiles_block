(function() {

	function tilesBlockApi($q, $http, umbRequestHelper) {
		return {
			getTilesSettings: function () {
				return $http.get(umbRequestHelper.getApiUrl("tilesBlockApi", "GetTilesSettings"));
			},

			getTilesTypes: function () {
				return $http.get(umbRequestHelper.getApiUrl("tilesBlockApi", "GetTilesTypes"));
			}
		};
	}

	angular.module('umbraco.resources').factory('tilesBlockApi', tilesBlockApi);
})();