import Vue from 'vue'

import ElementUI from 'element-ui'
import locale from 'element-ui/lib/locale'
import ruLocale from 'element-ui/lib/locale/lang/ru-RU'
import axios from 'axios';
import Header from "~/components/Header.vue";

locale.use(ruLocale);
Vue.use(ElementUI, { ruLocale });
Vue.prototype.$axios = axios;

Vue.component("print-layer-header", Header);

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
                this.$axios.post('/account/login', model, {
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
            },
            registration: function () {
                //console.log(this.login);
                var self = this;
                var model = {
                    login: this.login,
                    password: this.password
                }
                this.$axios.post('/account/registration', model, {
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
            },
            getOrders: function () {
                var self = this;
                this.$axios.get('/order',{
                        headers: {
                            'Content-Type': 'application/json'
                        }
                    })
                    .then(function (response) {
                        console.log(response);
                    })
                    .catch(function (error) {
                        console.log(error);
                    });
            }
        }
    });
}

startOnLoad();