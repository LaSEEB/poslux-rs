from neuxus.nodes import *

#lsl_reception = io.LslReceive(
#    prop='type',
#    value='EEG',
#    data_type='signal'
#)
# receive signals from BrainProducts Recorder via RDA
rda_receive = io.RdaReceive(
    rdaport=51244,
    offset=.0,
    host='localhost')

# dir_path is the path to directory containing this file
stim_cfg = dir_path + '/stimulations.xml'

# Generate stimulations
generated_markers = stimulator.Stimulator(
    file=stim_cfg
)

# send markers via LSL
lsl_markersd = io.LslSend(
    input_port=generated_markers.output,
    type="marker",
    name='eoec_markers'
)

# send RDA signals via LSL
lsl_signal = io.LslSend(
    input_port=rda_receive.output,
    type="EEG",
    name='eoec_signal'
)
