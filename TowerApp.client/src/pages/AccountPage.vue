<template>
  <div class="about text-center">
    <h1>Welcome {{ account }}</h1>
    <img class="rounded"  alt="" />
    <p>{{ account }}</p>
  </div>
</template>

<script>
import { computed, onMounted, reactive } from 'vue'
import { AppState } from '../AppState'
import {accountService} from '../services/AccountService'
export default {
  name: 'Account',
  setup() {
    const state = reactive({
      user: computed(() => AppState.user),
      account: computed(() => AppState.account)
    })
    onMounted(async() => {
      try {
        await accountService.getAccount()
      } catch (error) {
        logger.log(error)
      }
    })
    return {
      state,


    }
  }
}
</script>

<style scoped>
img {
  max-width: 100px;
}
</style>
