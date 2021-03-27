from neuxus.nodes import *

#lsl_reception = io.LslReceive(
#    prop='type',
#    value='EEG',
#    data_type='signal'
#)

# dir_path is the path to directory containing this file
stim_cfg = dir_path + '/stimulations.xml'

# Node 1
generated_markers = stimulator.Stimulator(
    file=stim_cfg
)


lsl_send = io.LslSend(
    input_port=generated_markers.output,
    type="marker",
    name='eoec_markers'
)
