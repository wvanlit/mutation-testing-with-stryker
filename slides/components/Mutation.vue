<script setup lang="ts">
defineProps<{
    mutation: string;
}>();
</script>

<template>
    <div class="text-center">
        <h3>{{ mutation }}</h3>
        <p>
            <slot />
        </p>
    </div>
</template>