using SerializationSystem;

namespace Protocol.Custom {
    public class Vector3 {
        public Vector3() : this(0) {
        }

        public Vector3(float value) : this(value, value, value) {
        }

        public Vector3(float x, float y, float z) {
            X = x;
            Y = y;
            Z = z;
        }

        [field: Serialized] public float X { get; set; }
        [field: Serialized] public float Y { get; set; }
        [field: Serialized] public float Z { get; set; }
    }

    public class Transform {
        public Transform() : this(new Vector3(0, 0, 0), new Vector3(1, 1, 1), new Vector3(0, 0, 0)) {
        }

        public Transform(Vector3 position, Vector3 scale, Vector3 eulerAngles) {
            Position = position;
            Scale = scale;
            EulerAngles = eulerAngles;
        }

        [field: Serialized] public Vector3 Position { get; set; }
        [field: Serialized] public Vector3 Scale { get; set; }
        [field: Serialized] public Vector3 EulerAngles { get; set; }
    }
}