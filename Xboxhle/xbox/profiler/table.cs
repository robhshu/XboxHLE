/*
Copyright (C) 2015  Gabriel Maldonado

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or 
any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>

* Linkedin: https://www.linkedin.com/pub/gabriel-maldonado/63/457/866
* Github: https://github.com/Gabriel-Maldonado/XboxHLE
*/

using System;
using System.Text;

namespace xboxhle.xbox.profiler
{
    public class table
    {
        static void i386_table(int index)
        {
            string[] table = { "" };
        }

        public static string kernel_Thunk_table(int index)
        {
            //Kernel Thunk Table
            string[] table = {"NULL", "AvGetSavedDataAddress","AvSendTVEncoderOption","AvSetDisplayMode","AvSetSavedDataAddress","DbgBreakPoint",  
           "DbgBreakPointWithStatus","DbgLoadImageSymbols","DbgPrint","HalReadSMCTrayState","DbgPrompt","DbgUnLoadImageSymbols",
           "ExAcquireReadWriteLockExclusive","ExAcquireReadWriteLockShared","ExAllocatePool","ExAllocatePoolWithTag","ExEventObjectType",
           "ExFreePool","ExInitializeReadWriteLock","ExInterlockedAddLargeInteger","ExInterlockedAddLargeStatistic","ExInterlockedCompareExchange64",
           "ExMutantObjectType","ExQueryPoolBlockSize","ExQueryNonVolatileSetting","ExReadWriteRefurbInfo","ExRaiseException","ExRaiseStatus",
           "ExReleaseReadWriteLock","ExSaveNonVolatileSetting","ExSemaphoreObjectType","ExTimerObjectType","ExfInterlockedInsertHeadList",
           "ExfInterlockedInsertTailList","ExfInterlockedRemoveHeadList","FscGetCacheSize","FscInvalidateIdleBlocks","FscSetCacheSize",
           "HalClearSoftwareInterrupt","HalDisableSystemInterrupt","HalDiskCachePartitionCount","HalDiskModelNumber","HalDiskSerialNumber",
           "HalEnableSystemInterrupt","HalGetInterruptVector","HalReadSMBusValue","HalReadWritePCISpace","HalRegisterShutdownNotification",
           "HalRequestSoftwareInterrupt","HalReturnToFirmware","HalWriteSMBusValue","InterlockedCompareExchange","InterlockedDecrement", 
           "InterlockedIncrement","InterlockedExchange","InterlockedExchangeAdd","InterlockedFlushSList","InterlockedPopEntrySList",
           "InterlockedPushEntrySList","IoAllocateIrp","IoBuildAsynchronousFsdRequest","IoBuildDeviceIoControlRequest", 
           "IoBuildSynchronousFsdRequest","IoCheckShareAccess","IoCompletionObjectType","IoCreateDevice","IoCreateFile","IoCreateSymbolicLink",
           "IoDeleteDevice","IoDeleteSymbolicLink","IoDeviceObjectType","IoFileObjectType","IoFreeIrp","IoInitializeIrp","IoInvalidDeviceRequest",
           "IoQueryFileInformation","IoQueryVolumeInformation","IoQueueThreadIrp","IoRemoveShareAccess","IoSetIoCompletion","IoSetShareAccess",
           "IoStartNextPacket","IoStartNextPacketByKey","IoStartPacket","IoSynchronousDeviceIoControlRequest","IoSynchronousFsdRequest",
           "IofCallDriver","IofCompleteRequest","KdDebuggerEnabled","KdDebuggerNotPresent","IoDismountVolume","IoDismountVolumeByName",
           "KeAlertResumeThread","KeAlertThread","KeBoostPriorityThread","KeBugCheck","KeBugCheckEx","KeCancelTimer","KeConnectInterrupt",
           "KeDelayExecutionThread","KeDisconnectInterrupt","KeEnterCriticalRegion","MmGlobalData","KeGetCurrentIrql","KeGetCurrentThread",
           "KeInitializeApc","KeInitializeDeviceQueue","KeInitializeDpc","KeInitializeEvent",
           "KeInitializeInterrupt","KeInitializeMutant","KeInitializeQueue","KeInitializeSemaphore","KeInitializeTimerEx","KeInsertByKeyDeviceQueue",
           "KeInsertDeviceQueue","KeInsertHeadQueue","KeInsertQueue","KeInsertQueueApc","KeInsertQueueDpc","KeInterruptTime","KeIsExecutingDpc",
           "KeLeaveCriticalRegion","KePulseEvent","KeQueryBasePriorityThread","KeQueryInterruptTime","KeQueryPerformanceCounter",
           "KeQueryPerformanceFrequency","KeQuerySystemTime","KeRaiseIrqlToDpcLevel","KeRaiseIrqlToSynchLevel","KeReleaseMutant",
           "KeReleaseSemaphore","KeRemoveByKeyDeviceQueue","KeRemoveDeviceQueue","KeRemoveEntryDeviceQueue","KeRemoveQueue","KeRemoveQueueDpc",
           "KeResetEvent","KeRestoreFloatingPointState","KeResumeThread","KeRundownQueue","KeSaveFloatingPointState","KeSetBasePriorityThread",
           "KeSetDisableBoostThread","KeSetEvent","KeSetEventBoostPriority","KeSetPriorityProcess","KeSetPriorityThread","KeSetTimer",
           "KeSetTimerEx","KeStallExecutionProcessor","KeSuspendThread","KeSynchronizeExecution","KeSystemTime","KeTestAlertThread",
           "KeTickCount","KeTimeIncrement","KeWaitForMultipleObjects","KeWaitForSingleObject","KfRaiseIrql","KfLowerIrql","KiBugCheckData",
           "KiUnlockDispatcherDatabase","LaunchDataPage","MmAllocateContiguousMemory","MmAllocateContiguousMemoryEx","MmAllocateSystemMemory",
           "MmClaimGpuInstanceMemory","MmCreateKernelStack","MmDeleteKernelStack","MmFreeContiguousMemory","MmFreeSystemMemory",
           "MmGetPhysicalAddress","MmIsAddressValid","MmLockUnlockBufferPages","MmLockUnlockPhysicalPage","MmMapIoSpace","MmPersistContiguousMemory",
           "MmQueryAddressProtect","MmQueryAllocationSize","MmQueryStatistics","MmSetAddressProtect","MmUnmapIoSpace","NtAllocateVirtualMemory",
           "NtCancelTimer","NtClearEvent","NtClose","NtCreateDirectoryObject","NtCreateEvent","NtCreateFile","NtCreateIoCompletion",
           "NtCreateMutant","NtCreateSemaphore","NtCreateTimer","NtDeleteFile","NtDeviceIoControlFile","NtDuplicateObject","NtFlushBuffersFile",
           "NtFreeVirtualMemory","NtFsControlFile","NtOpenDirectoryObject","NtOpenFile","NtOpenSymbolicLinkObject","NtProtectVirtualMemory",
           "NtPulseEvent","NtQueueApcThread","NtQueryDirectoryFile","NtQueryDirectoryObject","NtQueryEvent","NtQueryFullAttributesFile",
           "NtQueryInformationFile","NtQueryIoCompletion","NtQueryMutant","NtQuerySemaphore","NtQuerySymbolicLinkObject","NtQueryTimer",
           "NtQueryVirtualMemory","NtQueryVolumeInformationFile","NtReadFile","NtReadFileScatter","NtReleaseMutant","","NtReleaseSemaphore",
           "NtRemoveIoCompletion","NtResumeThread","NtSetEvent","NtSetInformationFile","NtSetIoCompletion","NtSetSystemTime","NtSetTimerEx",
           "NtSignalAndWaitForSingleObjectEx","NtSuspendThread","NtUserIoApcDispatcher","NtWaitForSingleObject","NtWaitForSingleObjectEx",
           "NtWaitForMultipleObjectsEx","NtWriteFile","NtWriteFileGather","NtYieldExecution","ObCreateObject","ObDirectoryObjectType",
           "ObInsertObject","ObMakeTemporaryObject","ObOpenObjectByName","ObOpenObjectByPointer","ObpObjectHandleTable","ObReferenceObjectByHandle",
           "ObReferenceObjectByName","ObReferenceObjectByPointer","ObSymbolicLinkObjectType","ObfDereferenceObject","ObfReferenceObject",
           "PhyGetLinkState","PhyInitialize","PsCreateSystemThread","PsCreateSystemThreadEx","PsQueryStatistics","PsSetCreateThreadNotifyRoutine",
           "PsTerminateSystemThread","PsThreadObjectType","RtlAnsiStringToUnicodeString","RtlAppendStringToString",
           "RtlAppendUnicodeStringToString","RtlAppendUnicodeToString","RtlAssert","RtlCaptureContext","RtlCaptureStackBackTrace",
           "RtlCharToInteger","RtlCompareMemory","RtlCompareMemoryUlong","RtlCompareString","RtlCompareUnicodeString","RtlCopyString",
           "RtlCopyUnicodeString","RtlCreateUnicodeString","RtlDowncaseUnicodeChar","RtlDowncaseUnicodeString","RtlEnterCriticalSection",
           "RtlEnterCriticalSectionAndRegion","RtlEqualString","RtlEqualUnicodeString","RtlExtendedIntegerMultiply",
           "RtlExtendedLargeIntegerDivide","RtlExtendedMagicDivide","RtlFillMemory","RtlFillMemoryUlong","RtlFreeAnsiString",
           "RtlFreeUnicodeString","RtlGetCallersAddress","RtlInitAnsiString","RtlInitUnicodeString","RtlInitializeCriticalSection",
           "RtlIntegerToChar","RtlIntegerToUnicodeString","RtlLeaveCriticalSection","RtlLeaveCriticalSectionAndRegion","RtlLowerChar",
           "RtlMapGenericMask","RtlMoveMemory","RtlMultiByteToUnicodeN","RtlMultiByteToUnicodeSize","RtlNtStatusToDosError",
           "RtlRaiseException","RtlRaiseStatus","RtlTimeFieldsToTime","RtlTimeToTimeFields","RtlTryEnterCriticalSection",
           "RtlUlongByteSwap","RtlUnicodeStringToAnsiString","RtlUnicodeStringToInteger","RtlUnicodeToMultiByteN",
           "RtlUnicodeToMultiByteSize","RtlUnwind","RtlUpcaseUnicodeChar","RtlUpcaseUnicodeString","RtlUpcaseUnicodeToMultiByteN",
           "RtlUpperChar","RtlUpperString","RtlUshortByteSwap","RtlWalkFrameChain","RtlZeroMemory","XboxEEPROMKey",
           "XboxHardwareInfo","XboxHDKey","XboxKrnlVersion","XboxSignatureKey","XeImageFileName","XeLoadSection"
           ,"XeUnloadSection","READ_PORT_BUFFER_UCHAR","READ_PORT_BUFFER_USHORT","READ_PORT_BUFFER_ULONG","WRITE_PORT_BUFFER_UCHAR",
           "WRITE_PORT_BUFFER_USHORT","WRITE_PORT_BUFFER_ULONG","XcSHAInit","XcSHAUpdate","XcSHAFinal","XcRC4Key","XcRC4Crypt",
           "XcHMAC","XcPKEncPublic","XcPKDecPrivate","XcPKGetKeyLen","XcVerifyPKCS1Signature","XcModExp","XcDESKeyParity","XcKeyTable",
           "XcBlockCrypt","XcBlockCryptCBC","XcCryptService","XcUpdateCrypto","RtlRip","XboxLANKey","XboxAlternateSignatureKeys",
           "XePublicKeyData","HalBootSMCVideoMode","IdexChannelObject","HalIsResetOrShutdownPending","IoMarkIrpMustComplete",
           "HalInitiateShutdown","snprintf","sprintf","vsnprintf","vsprintf","HalEnableSecureTrayEject","HalWriteSMCScratchRegister"};
            return table[index];
        }
    }
}
