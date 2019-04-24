<template>

    <div class="app-dashboard-sidebarmenu">


            <v-list>

                <v-list-group prepend-icon="fa-cog" value="true">

                    <template v-slot:activator>
                        <v-list-tile>
                            <v-list-tile-title>Basic Examples</v-list-tile-title>
                        </v-list-tile>
                    </template>

                    <v-list-tile to="/counter">
                        <v-list-tile-title>Counter Example</v-list-tile-title>
                    </v-list-tile>

                    <v-list-tile to="/fetchdata">
                        <v-list-tile-title>Fetch Data Example</v-list-tile-title>
                        <v-list-tile-action>
                            <v-icon>fa-cog</v-icon>
                        </v-list-tile-action>
                    </v-list-tile>

                    <v-list-tile to="/test1">
                        <v-list-tile-title>Test1</v-list-tile-title>
                    </v-list-tile>

                    <v-list-tile to="/test2">
                        <v-list-tile-title>Test2</v-list-tile-title>
                    </v-list-tile>

                </v-list-group>

                <v-list-group>

                    <template v-slot:activator>
                        <v-list-tile>
                            <v-list-tile-title>Sub Menu Example</v-list-tile-title>
                        </v-list-tile>
                    </template>

                    <v-list-group sub-group no-action>

                        <template v-slot:activator>
                            <v-list-tile>
                                <v-list-tile-title>Sub Menu1 1</v-list-tile-title>
                            </v-list-tile>
                        </template>

                        <v-list-tile>
                            <v-list-tile-title>Thing1</v-list-tile-title>
                        </v-list-tile>

                        <v-list-tile>
                            <v-list-tile-title>Thing2</v-list-tile-title>
                        </v-list-tile>

                        <v-list-tile>
                            <v-list-tile-title>Thing3</v-list-tile-title>
                        </v-list-tile>

                    </v-list-group>

                </v-list-group>

            </v-list>

    </div>
</template>

<script src="./sidebarmenu.ts"></script>
