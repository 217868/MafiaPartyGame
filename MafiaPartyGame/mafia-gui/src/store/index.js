import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

import moduleHostUI from '@/store/modules/moduleHostUI.js'
import moduleStates from './modules/moduleStates'
import moduleConnection from './modules/moduleConnection'
import modulePlayers from './modules/modulePlayers'
import moduleVoting from './modules/moduleVoting'
export default new Vuex.Store({
  modules: {
    HostUI: moduleHostUI,
    States: moduleStates,
    Connection: moduleConnection,
    Players: modulePlayers,
    Voting: moduleVoting
  }
})
