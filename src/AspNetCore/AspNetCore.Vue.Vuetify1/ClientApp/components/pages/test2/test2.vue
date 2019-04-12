
<template>
    <v-container fluid fill-height>
        <v-layout justify-center align-center>
            <v-flex shrink>

                <v-tooltip right>
                    <template v-slot:activator="{ on }">
                        <v-btn :href="source" icon large target="_blank" v-on="on">
                            <v-icon large>fa-code</v-icon>
                        </v-btn>
                    </template>
                    <span>Source</span>
                </v-tooltip>

                <v-tooltip right>
                    <template v-slot:activator="{ on }">
                        <v-btn icon large href="https://codepen.io/johnjleider/pen/qxQWda" target="_blank" v-on="on">
                            <v-icon large>fa-codepen</v-icon>
                        </v-btn>
                    </template>
                    <span>Codepen</span>
                </v-tooltip>

            </v-flex>
        </v-layout>
    </v-container>
</template>
