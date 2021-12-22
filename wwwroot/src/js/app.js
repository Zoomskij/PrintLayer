import Vue from 'vue'

import ElementUI from 'element-ui'
import locale from 'element-ui/lib/locale'
import ruLocale from 'element-ui/lib/locale/lang/ru-RU'
import axios from 'axios';

import { Input } from 'element-ui'

locale.use(ruLocale);
Vue.use(ElementUI, { ruLocale });
Vue.prototype.$axios = axios;

Vue.use(Input);

function startOnLoad() {
    var app = new Vue({
        el: '#app',
        data: {
            message: 'Vue!',
            login: '',
            password: '',
            user:[]
        },
        methods: {
            auth: function () {
                //console.log(this.login);
                var self = this;
                var model = {
                    login: this.login,
                    password: this.password
                }
                this.$axios.post('/auth/login', model, {
                        headers: {
                            'Content-Type': 'application/json'
                        }
                    })
                    .then(function (response) {
                        self.user = response.data;
                        console.log(response);
                    })
                    .catch(function (error) {
                        self.user = error;
                        console.log(error);
                    });
            }
        }
    });
}

startOnLoad();