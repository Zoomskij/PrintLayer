import Vue from 'vue'

import ElementUI from 'element-ui'
import locale from 'element-ui/lib/locale'
import ruLocale from 'element-ui/lib/locale/lang/ru-RU'

locale.use(ruLocale);
Vue.use(ElementUI, { ruLocale });

function startOnLoad() {
    var app = new Vue({
        el: '#app',
        data: {
            message: 'Vue!'
        }
    });
}

startOnLoad();