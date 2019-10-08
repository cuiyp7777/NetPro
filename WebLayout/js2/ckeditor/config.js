/**
 * @license Copyright (c) 2003-2013, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.html or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function (config) {

    config.extraPlugins += (config.extraPlugins ? ',lineheight' : 'lineheight');
    CKEDITOR.config.toolbar =
    [
        { name: 'document2s', items: [ 'Maximize','NewPage', 'DocProps', 'Preview', 'Templates'] },
        { name: 'clipboard', items: ['Cut', 'Copy', 'Paste', 'PasteText', 'PasteFromWord', '-', 'Undo', 'Redo'] },
        { name: 'basicstyles', items: ['Bold', 'Italic', 'Underline', 'Strike', 'Subscript', 'Superscript', '-', 'RemoveFormat'] },
        { name: 'paragraph', items: ['NumberedList', 'BulletedList',/* '-', 'Outdent', 'Indent', '-', 'Blockquote', 'CreateDiv', '-',*/ 'JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock'/*, '-', 'BidiLtr', 'BidiRtl'*/] },
        { name: 'insert', items: ['Image',  'Table', 'HorizontalRule', 'Smiley', 'SpecialChar', 'PageBreak', 'Iframe'] },
                { name: 'editing', items: ['Find', 'Replace', '-', 'SelectAll', '-', 'SpellChecker', 'Scayt'] },
        { name: 'styles', items: ['Styles', 'Format', 'Font', 'FontSize', 'lineheight'] }, { name: 'colors', items: ['TextColor', 'BGColor'] }
       
    ];

    //去掉状态栏标签和状态栏的显示
    config.removePlugins = 'elementspath';
    config.resize_enabled = false;
    config.autoUpdateElement = true
    CKEDITOR.config.readOnly = false;

    config.startupFocus = true;

    //文字方向  
    config.contentsLangDirection = 'ltr'; //从左到右  
};
