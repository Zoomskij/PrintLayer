<template>
    <div style="display:flex; justify-content:flex-start">
        <el-row>
            <el-button v-on:click="getPdf()">GetPdf</el-button>
        </el-row>

    </div>
</template>

<script>
    export default {
        name: 'pdf',
        data() {
            return {
                items: []
            }
        },
        computed: {

        },
        methods: {
            getPdf: function () {
                var self = this;
                this.$axios.get('/pdf', {
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
        },
        mounted() {

        }
    }
</script>

<!--<style>
  .text {
    font-size: 14px;
  }

  .item {
    padding: 18px 0;
  }

  .box-card {
    width: 480px;
  }
</style>-->