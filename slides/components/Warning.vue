<script setup lang="ts">
import { computed } from 'vue';

const props = defineProps({
    name: String,
})

</script>

<template>
    <div class="flex bg-orange-100/50 border-1 border-orange p-2 m-1 rounded-md text-sm">
        <span class="mr-2">
            <carbon:warning-alt-filled class="color-orange-600" />
        </span>
        <span flex="1">{{ name }}</span>
    </div>
</template>