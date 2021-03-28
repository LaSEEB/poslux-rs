import socket
from pylsl import StreamInlet, resolve_stream

def main():
    # first resolve a marker stream on the lab network
    print("looking for a marker stream...")
    streams = resolve_stream('type', 'marker')

    s = socket.create_connection(("localhost", 22345))
    s.sendall(b"select all\n")
    s.sendall(b"filename {root:C:\\Users\\thanos\\Desktop\\EOEC_Data\\} {template:exp%n\\%p_block_%b.xdf} {run:1} {participant:P001} {task:EOEC}\n")
    s.sendall(b"start\n")
    print("Log started.")
    startlog = True;

    # create a new inlet to read from the stream
    inlet = StreamInlet(streams[0])

    while startlog:
        # get a new sample (you can also omit the timestamp part if you're not
        # interested in it)
        sample, timestamp = inlet.pull_sample()
        print("got %s at time %s" % (sample[0], timestamp))
        if sample[0] == 1010.0:
            #s.sendall(b"stop\n")
            startlog = False;


    s.sendall(b"stop\n")
    print("Log stopped.")

if __name__ == '__main__':
    main()
