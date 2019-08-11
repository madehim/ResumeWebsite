/// <binding BeforeBuild='sass' />
"use strict";

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    sass = require("gulp-sass"); // добавляем модуль sass

var paths = {
    webroot: "./wwwroot/"
};
// регистрируем задачу для конвертации файла scss в css
gulp.task("sass", function () {
    return gulp.src(paths.webroot + '/css/site.scss')
        .pipe(sass())
        .pipe(gulp.dest(paths.webroot + '/css'))
});