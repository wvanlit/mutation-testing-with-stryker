<script setup lang="ts">
import { computed } from 'vue';

const props = defineProps({
    state: String,
    name: String,
})

</script>

<template>
    <div class="border-1 p-2 m-1 rounded-md">
        <span class="mr-2">
            <carbon:checkmark-filled v-if="state == 'pass'" class="color-green-600" />
            <carbon:close-filled v-else-if="state == 'fail'" class="color-red-600" />
            <carbon:progress-bar-round v-else-if="state == 'skip'" class="color-gray-600" />
        </span>
        <span flex="1">
            <code>{{ name }}</code>
        </span>
    </div>
</template>
