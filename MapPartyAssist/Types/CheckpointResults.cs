﻿using System;

namespace MapPartyAssist.Types {
    public class CheckpointResults {
        public Checkpoint Checkpoint { get; init; }
        public DateTime Time { get; private set; }
        public bool IsReached {
            get { return _isReached; }
            set {
                if(value && !_isReached) {
                    Time = DateTime.Now;
                }
                _isReached = value;
            }
        }

        //these 2 properties should only be on RouletteCheckpoint, but we need them here for deserializing
        public Summon? SummonType { get; set; }
        public string? MonsterName { get; set; }

        private bool _isReached = false;

        public CheckpointResults(Checkpoint checkpoint, bool isReached = false) {
            Checkpoint = checkpoint;
            IsReached = isReached;
        }
    }
}
