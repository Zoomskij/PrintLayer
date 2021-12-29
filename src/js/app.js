import Vue from 'vue'
import VueRouter from 'vue-router'

import ElementUI from 'element-ui'
import locale from 'element-ui/lib/locale'
import ruLocale from 'element-ui/lib/locale/lang/ru-RU'
import axios from 'axios';
import Header from "~/components/Header.vue";
import Footer from "~/components/Footer.vue";

import Home from "~/Home/components/Root.vue";
import Review from "~/Review/components/Root.vue";
import Order from "~/Order/components/Root.vue";
import News from "~/Home/components/News.vue";
import Pdf from "~/Home/components/Pdf.vue";

Vue.use(VueRouter);
locale.use(ruLocale);
Vue.use(ElementUI, { ruLocale });
Vue.prototype.$axios = axios;

Vue.component("print-layer-header", Header);
Vue.component("print-layer-footer", Footer);
Vue.component("news", News);
Vue.component("pdf", Pdf);

function startOnLoad() {
    var router = new VueRouter({
        routes: [
            { path: '/', caseSensitive: false, component: Home },
            { path: '/review', caseSensitive: false, component: Review },
            { path: '/order', caseSensitive: false, component: Order }
        ]
    });
    Vue.config.devtools = true;

    var vv = new Vue({
        el: "#vue-router",
        router,
        data: {

        },
        methods: {
            back() {
                this.$router.go(-1);
            },

            // ROUTING ------------------------------------------
            isCurrentRoute(name) {
                return this.$route.name === name;
            },
        },


    });



    var app = new Vue({
        el: '#app',
        router,
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