var LayoutEditor;
(function ($, LayoutEditor) {

    LayoutEditor.Slider = function (data, htmlId, htmlClass, htmlStyle, isTemplated, legend, contentType, contentTypeLabel, contentTypeClass, hasEditor, children) {
        LayoutEditor.Element.call(this, "Slider", data, htmlId, htmlClass, htmlStyle, isTemplated);
        LayoutEditor.Container.call(this, ["Grid", "Content"], children);

        var self = this;
        this.isContainable = true;
        this.dropTargetClass = "layout-common-holder";
        this.contentType = contentType;
        this.contentTypeLabel = contentTypeLabel;
        this.contentTypeClass = contentTypeClass;
        this.legend = legend || "";
        this.hasEditor = hasEditor;

        this.toObject = function () {
            var result = this.elementToObject();
            result.legend = this.legend;
            result.children = this.childrenToObject();

            return result;
        };

        var getEditorObject = this.getEditorObject;
        this.getEditorObject = function () {
            var dto = getEditorObject();
            return $.extend(dto, {
                Legend: this.legend
            });
        }

        this.setChildren = function (children) {
            this.children = children;
            _(this.children).each(function (child) {
                child.parent = self;
            });
        };

        this.applyElementEditorModel = function (model) {
            this.legend = model.legend;
        };

        this.setChildren(children);
    };

    LayoutEditor.Slider.from = function (value) {
        return new LayoutEditor.Slider(
            value.data,
            value.htmlId,
            value.htmlClass,
            value.htmlStyle,
            value.isTemplated,
            value.legend,
            value.contentType,
            value.contentTypeLabel,
            value.contentTypeClass,
            value.hasEditor,
            LayoutEditor.childrenFrom(value.children));
    };

    LayoutEditor.registerFactory("Slider", function (value) {
        return LayoutEditor.Slider.from(value);
    });

})(jQuery, LayoutEditor || (LayoutEditor = {}));
angular
    .module("LayoutEditor")
    .directive("orcLayoutSlider", ["$compile", "scopeConfigurator", "environment",
        function ($compile, scopeConfigurator, environment) {
            return {
                restrict: "E",
                scope: { element: "=" },
                controller: ["$scope", "$element",
                    function ($scope, $element) {
                        scopeConfigurator.configureForElement($scope, $element);
                        scopeConfigurator.configureForContainer($scope, $element);
                        $scope.sortableOptions["axis"] = "y";
                        $scope.edit = function () {
                            $scope.$root.editElement($scope.element).then(function (args) {
                                if (args.cancel)
                                    return;
                                $scope.$apply(function () {
                                    $scope.element.data = decodeURIComponent(args.element.data);
                                    $scope.element.applyElementEditorModel(args.elementEditorModel);
                                });
                            });
                        };
                    }
                ],
                templateUrl: environment.templateUrl("Slider"),
                replace: true
            };
        }
    ]);