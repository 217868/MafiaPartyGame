<template>
  <div class="agentProtectResult">
    <div class="agentTitle" :style="{ color: PlayerTypesColors.AGENT}">AGENT</div>
    <div class="spacer1"/>
    <div class="protectLabel">Chronisz</div>
    <PlayerTagShort class="playerTag" :playerName="player.name" :color="'#' + player.color"/>
    <div class="goToSleepLabel" :style="{ color: PlayerTypesColors.MAFIA }">Idź spać!</div>
    <div class="spacer2"/>
  </div>
</template>

<script>
import { PlayerTypesColors } from './../../../enums/PlayerTypesColors'
import PlayerTagShort from './../../PlayerTagShort'
import * as MobileSignalService from './../../../services/MobileSignalService'

export default {
  name: 'AgentProtectResult',
  components: {
    PlayerTagShort
  },
  computed: {
    player() {
      return this.$store.state.Players.selectedPlayer;
    },
    PlayerTypesColors() {
      return PlayerTypesColors;
    }
  },
  created() {
    setTimeout(() => {
      MobileSignalService.OnAgentFinished(this.$store);
    }, 4000)
  }

}
</script>

<style scoped>
  .agentProtectResult{
    height: 100%;
    display: flex;
    flex-direction: column;

    align-items: center;

    animation: slideIn .3s;
  }

  .agentTitle {
    font-size: 3rem;
    margin-top: 1rem;
    margin-bottom: 1rem;
  }

  .protectLabel {
    font-size: 2rem;
  }

  .goToSleepLabel {
    font-size: 4rem;
    margin-top: 3rem;
    margin-bottom: 3rem;
  }

  .spacer1 {
    flex: 1;
  }

  .spacer2 {
    flex: 2;
  }

</style>
