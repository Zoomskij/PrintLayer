<template>
    <div>
        <el-row>
            <el-button v-on:click="addReview()">add review component</el-button>
        </el-row>
    </div>
</template>

<script>
    export default {
        name: 'root',
        data() {
            return {
                
            }
        },
        computed: {

        },
        methods: {
            addReview: function () {
                var self = this;

                var review = {
                    grade: 4,
                    description: 'This is a test description!'
                }

                this.$axios({
                    method: 'post',
                    url: '/review/add',
                    data: review
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