﻿using System;
        public int kinState = 0;

                            //********************** Read Loop *******************************************
                            // CRISTART 1234 msgtype content CRIEND
                            // wait for "CRISTART" and then read until "CRIEND"
                            while (true)
                            // read the content until CRIEND
                            int cnt = 8;

                            // evaluate the content
                            string res = Encoding.ASCII.GetString(buffer, 0, cnt);

                        }
                    EXECEND = true;
                }
                // for data collection
