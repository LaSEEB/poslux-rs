import socket
s = socket.create_connection(("localhost", 22345))
s.sendall(b"select all\n")
s.sendall(b"filename {root:C:\\Data\\} {template:exp%n\\%p_block_%b.xdf} {run:2} {participant:P003} {task:MemoryGuided}\n")
s.sendall(b"start\n")